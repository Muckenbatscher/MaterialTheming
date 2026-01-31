using MaterialTheming.MaterialDesign.HctConversion;

namespace MaterialTheming.MaterialDesign.Temperature;

/// <summary>
/// Design utilities using color temperature theory.
/// Analogous colors, complementary color, and cache to efficiently, lazily, generate data for
/// calculations when needed.
/// </summary>
internal class TemperatureCache
{
    private readonly HctColor _input;

    private HctColor? _precomputedComplement;
    private List<HctColor>? _precomputedHctsByTemp;
    private List<HctColor>? _precomputedHctsByHue;
    private Dictionary<HctColor, double>? _precomputedTempsByHct;

    public TemperatureCache(HctColor input)
    {
        _input = input;
    }

    /// <summary>
    /// A color that complements the input color aesthetically.
    /// In art, this is usually described as being across the color wheel. History of this shows
    /// intent as a color that is just as cool-warm as the input color is warm-cool.
    /// </summary>
    public HctColor GetComplement()
    {
        if (_precomputedComplement is not null)
            return _precomputedComplement;

        double coldestHue = GetColdest().Hue;
        double coldestTemp = GetTempsByHct()[GetColdest()];

        double warmestHue = GetWarmest().Hue;
        double warmestTemp = GetTempsByHct()[GetWarmest()];
        double range = warmestTemp - coldestTemp;

        bool startHueIsColdestToWarmest = IsBetween(_input.Hue, coldestHue, warmestHue);
        double startHue = startHueIsColdestToWarmest ? warmestHue : coldestHue;
        double endHue = startHueIsColdestToWarmest ? coldestHue : warmestHue;
        double directionOfRotation = 1.0;
        double smallestError = 1000.0;
        HctColor answer = GetHctsByHue()[(int)Math.Round(_input.Hue)];

        double complementRelativeTemp = 1.0 - GetRelativeTemperature(_input);

        // Find the color in the other section, closest to the inverse percentile
        // of the input color. This is the complement.
        for (double hueAddend = 0.0; hueAddend <= 360.0; hueAddend += 1.0)
        {
            double hue = MathUtils.SanitizeDegrees(startHue + directionOfRotation * hueAddend);
            if (!IsBetween(hue, startHue, endHue))
            {
                continue;
            }
            HctColor possibleAnswer = GetHctsByHue()[(int)Math.Round(hue)];
            double relativeTemp = (GetTempsByHct()[possibleAnswer] - coldestTemp) / range;
            double error = Math.Abs(complementRelativeTemp - relativeTemp);
            if (error < smallestError)
            {
                smallestError = error;
                answer = possibleAnswer;
            }
        }
        _precomputedComplement = answer;
        return _precomputedComplement;
    }

    /// <summary>
    /// 5 colors that pair well with the input color.
    /// The colors are equidistant in temperature and adjacent in hue.
    /// </summary>
    public List<HctColor> GetAnalogousColors()
    {
        return GetAnalogousColors(5, 12);
    }

    /// <summary>
    /// A set of colors with differing hues, equidistant in temperature.
    /// </summary>
    public List<HctColor> GetAnalogousColors(int count, int divisions)
    {
        // The starting hue is the hue of the input color.
        int startHue = (int)Math.Round(_input.Hue);
        HctColor startHct = GetHctsByHue()[startHue];
        double lastTemp = GetRelativeTemperature(startHct);

        List<HctColor> allColors = new() { startHct };

        double absoluteTotalTempDelta = 0.0;
        for (int i = 0; i < 360; i++)
        {
            int hue = (int)MathUtils.SanitizeDegrees(startHue + i);
            HctColor hct = GetHctsByHue()[hue];
            double temp = GetRelativeTemperature(hct);
            double tempDelta = Math.Abs(temp - lastTemp);
            lastTemp = temp;
            absoluteTotalTempDelta += tempDelta;
        }

        int hueAddend = 1;
        double tempStep = absoluteTotalTempDelta / (double)divisions;
        double totalTempDelta = 0.0;
        lastTemp = GetRelativeTemperature(startHct);

        while (allColors.Count < divisions)
        {
            int hue = (int)MathUtils.SanitizeDegrees(startHue + hueAddend);
            HctColor hct = GetHctsByHue()[hue];
            double temp = GetRelativeTemperature(hct);
            double tempDelta = Math.Abs(temp - lastTemp);
            totalTempDelta += tempDelta;

            double desiredTotalTempDeltaForIndex = allColors.Count * tempStep;
            bool indexSatisfied = totalTempDelta >= desiredTotalTempDeltaForIndex;
            int indexAddend = 1;

            // Keep adding this hue to the answers until its temperature is
            // insufficient. This ensures consistent behavior when there aren't
            // `divisions` discrete steps between 0 and 360 in hue with `tempStep`
            // delta in temperature between them.
            while (indexSatisfied && allColors.Count < divisions)
            {
                allColors.Add(hct);
                desiredTotalTempDeltaForIndex = (allColors.Count + indexAddend) * tempStep;
                indexSatisfied = totalTempDelta >= desiredTotalTempDeltaForIndex;
                indexAddend++;
            }
            lastTemp = temp;
            hueAddend++;

            if (hueAddend > 360)
            {
                while (allColors.Count < divisions)
                {
                    allColors.Add(hct);
                }
                break;
            }
        }

        List<HctColor> answers = new() { _input };

        int ccwCount = (int)Math.Floor((count - 1.0) / 2.0);
        for (int i = 1; i < ccwCount + 1; i++)
        {
            int index = 0 - i;
            while (index < 0)
            {
                index = allColors.Count + index;
            }
            if (index >= allColors.Count)
            {
                index = index % allColors.Count;
            }
            answers.Insert(0, allColors[index]);
        }

        int cwCount = count - ccwCount - 1;
        for (int i = 1; i < cwCount + 1; i++)
        {
            int index = i;
            while (index < 0)
            {
                index = allColors.Count + index;
            }
            if (index >= allColors.Count)
            {
                index = index % allColors.Count;
            }
            answers.Add(allColors[index]);
        }

        return answers;
    }

    /// <summary>
    /// Temperature relative to all colors with the same chroma and tone.
    /// Value on a scale from 0 to 1.
    /// </summary>
    public double GetRelativeTemperature(HctColor hct)
    {
        double range = GetTempsByHct()[GetWarmest()] - GetTempsByHct()[GetColdest()];
        double differenceFromColdest = GetTempsByHct()[hct] - GetTempsByHct()[GetColdest()];

        if (range == 0.0)
        {
            return 0.5;
        }
        return differenceFromColdest / range;
    }

    /// <summary>
    /// Value representing cool-warm factor of a color.
    /// Values below 0 are considered cool, above, warm.
    /// </summary>
    public static double RawTemperature(HctColor color)
    {
        double[] lab = ColorUtils.LabFromRgb(color.ToRgbColor());
        // Calculate Hue in Radians, then convert to Degrees
        double hue = MathUtils.SanitizeDegrees(Math.Atan2(lab[2], lab[1]) * (180.0 / Math.PI));
        double chroma = Math.Sqrt(lab[1] * lab[1] + lab[2] * lab[2]); // Math.Hypot

        // Convert back to Radians for Cosine
        return -0.5 + 0.02 * Math.Pow(chroma, 1.07) * Math.Cos((MathUtils.SanitizeDegrees(hue - 50.0)) * (Math.PI / 180.0));
    }

    private HctColor GetColdest()
    {
        return GetHctsByTemp()[0];
    }

    private List<HctColor> GetHctsByHue()
    {
        if (_precomputedHctsByHue != null)
        {
            return _precomputedHctsByHue;
        }

        List<HctColor> hcts = new();
        for (double hue = 0.0; hue <= 360.0; hue += 1.0)
        {
            hcts.Add(HctColor.From(hue, _input.Chroma, _input.Tone));
        }
        _precomputedHctsByHue = hcts;
        return _precomputedHctsByHue;
    }

    private List<HctColor> GetHctsByTemp()
    {
        if (_precomputedHctsByTemp != null)
        {
            return _precomputedHctsByTemp;
        }

        List<HctColor> hcts = new(GetHctsByHue());
        hcts.Add(_input);

        hcts.Sort((a, b) => GetTempsByHct()[a].CompareTo(GetTempsByHct()[b]));

        _precomputedHctsByTemp = hcts;
        return _precomputedHctsByTemp;
    }

    private Dictionary<HctColor, double> GetTempsByHct()
    {
        if (_precomputedTempsByHct != null)
        {
            return _precomputedTempsByHct;
        }

        List<HctColor> allHcts = new(GetHctsByHue());
        allHcts.Add(_input);

        Dictionary<HctColor, double> temperaturesByHct = new();
        foreach (HctColor hct in allHcts)
        {
            if (!temperaturesByHct.ContainsKey(hct))
            {
                temperaturesByHct.Add(hct, RawTemperature(hct));
            }
        }

        _precomputedTempsByHct = temperaturesByHct;
        return _precomputedTempsByHct;
    }

    private HctColor GetWarmest()
    {
        return GetHctsByTemp()[GetHctsByTemp().Count - 1];
    }

    private static bool IsBetween(double angle, double a, double b)
    {
        if (a < b)
        {
            return a <= angle && angle <= b;
        }
        return a <= angle || angle <= b;
    }
}