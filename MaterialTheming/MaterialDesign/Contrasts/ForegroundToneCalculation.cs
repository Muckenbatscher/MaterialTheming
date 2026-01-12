using MaterialTheming.MaterialDesign.DynamicColors;

namespace MaterialTheming.MaterialDesign.Contrasts;

internal class ForegroundToneCalculation
{
    /// <summary>
    /// Given a background tone, find a foreground tone, while ensuring they reach a contrast ratio
    /// that is as close to ratio as possible.
    /// </summary>
    public static double ForegroundTone(double bgTone, double ratio)
    {
        double lighterTone = Contrast.LighterUnsafe(bgTone, ratio);
        double darkerTone = Contrast.DarkerUnsafe(bgTone, ratio);
        double lighterRatio = Contrast.RatioOfTones(lighterTone, bgTone);
        double darkerRatio = Contrast.RatioOfTones(darkerTone, bgTone);
        bool preferLighter = TonePrefersLightForeground(bgTone);

        if (preferLighter)
        {
            // "Neglible difference" handles an edge case where the initial contrast ratio is high
            // (ex. 13.0), and the ratio passed to the function is that high ratio, and both the lighter
            // and darker ratio fails to pass that ratio.
            //
            // This was observed with Tonal Spot's On Primary Container turning black momentarily between
            // high and max contrast in light mode. PC's standard tone was T90, OPC's was T10, it was
            // light mode, and the contrast level was 0.6568521221032331.
            bool negligibleDifference =
                Math.Abs(lighterRatio - darkerRatio) < 0.1 && lighterRatio < ratio && darkerRatio < ratio;

            if (lighterRatio >= ratio || lighterRatio >= darkerRatio || negligibleDifference)
            {
                return lighterTone;
            }
            else
            {
                return darkerTone;
            }
        }
        else
        {
            return darkerRatio >= ratio || darkerRatio >= lighterRatio ? darkerTone : lighterTone;
        }
    }

    /// <summary>
    /// People prefer white foregrounds on ~T60-70. Observed over time, and also by Andrew Somers
    /// during research for APCA.
    /// </summary>
    public static bool TonePrefersLightForeground(double tone)
    {
        return Math.Round(tone) < 60;
    }

    /// <summary>
    /// Tones less than ~T50 always permit white at 4.5 contrast.
    /// </summary>
    public static bool ToneAllowsLightForeground(double tone)
    {
        return Math.Round(tone) <= 49;
    }

    public static Func<DynamicScheme, double> GetInitialToneFromBackground(Func<DynamicScheme, DynamicColor?>? background)
    {
        if (background == null)
            return _ => 50.0;

        return scheme =>
        {
            var bgColor = background(scheme);
            return bgColor?.GetTone(scheme) ?? 50.0;
        };
    }
}
