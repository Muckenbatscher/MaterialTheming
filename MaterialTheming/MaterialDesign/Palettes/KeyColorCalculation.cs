namespace MaterialTheming.MaterialDesign.Palettes;

/// <summary>
/// Key color is a color that represents the hue and chroma of a tonal palette.
/// This class encapsulates the logic for calculating it.
/// </summary>
internal class KeyColorCalculation
{
    private readonly double _hue;
    private readonly double _requestedChroma;
    private const double MaxChromaValue = 200.0;

    private KeyColorCalculation(double hue, double requestedChroma)
    {
        _hue = hue;
        _requestedChroma = requestedChroma;
    }

    public static HctColor Create(double hue, double requestedChroma)
    {
        return new KeyColorCalculation(hue, requestedChroma).Calculate();
    }

    private HctColor Calculate()
    {
        // Pivot around T50 because T50 has the most chroma available, on average.
        // Thus it is most likely to have a direct answer.
        const int pivotTone = 50;
        const int toneStepSize = 1;
        // Epsilon to accept values slightly higher than the requested chroma.
        const double epsilon = 0.01;

        // Binary search to find the tone that can provide a chroma that is closest
        // to the requested chroma.
        int lowerTone = 0;
        int upperTone = 100;

        while (lowerTone < upperTone)
        {
            int midTone = (lowerTone + upperTone) / 2;
            bool isAscending = MaxChroma(midTone) < MaxChroma(midTone + toneStepSize);
            bool sufficientChroma = MaxChroma(midTone) >= _requestedChroma - epsilon;

            if (sufficientChroma)
            {
                // Either range [lowerTone, midTone] or [midTone, upperTone] has
                // the answer, so search in the range that is closer the pivot tone.
                if (Math.Abs(lowerTone - pivotTone) < Math.Abs(upperTone - pivotTone))
                {
                    upperTone = midTone;
                }
                else
                {
                    if (lowerTone == midTone)
                    {
                        return HctColor.From(_hue, _requestedChroma, lowerTone);
                    }
                    lowerTone = midTone;
                }
            }
            else
            {
                // As there is no sufficient chroma in the midTone, follow the direction to the chroma peak.
                if (isAscending)
                    lowerTone = midTone + toneStepSize;
                else
                    upperTone = midTone; // Keep midTone for potential chroma peak.
            }
        }

        return HctColor.From(_hue, _requestedChroma, lowerTone);
    }

    // Find the maximum chroma for a given tone
    private double MaxChroma(int tone)
        => HctColor.From(_hue, MaxChromaValue, tone).Chroma;
}