using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.MaterialDesign.Dislike;

/// <summary>
/// Check and/or fix universally disliked colors.
/// Color science studies of color preference indicate universal distaste for dark yellow-greens,
/// and also show this is correlated to distaste for biological waste and rotting food.
/// </summary>
internal class DislikeAnalyzer
{
    /// <summary>
    /// Returns true if color is disliked.
    /// Disliked is defined as a dark yellow-green that is not neutral.
    /// </summary>
    public static bool IsDisliked(HctColor hct)
    {
        // Java Math.round rounds to the nearest long (breaking ties to positive infinity).
        // We use AwayFromZero to match this behavior for positive numbers (Hue/Chroma/Tone are positive).
        bool huePasses = Math.Round(hct.Hue, MidpointRounding.AwayFromZero) >= 90.0 &&
                         Math.Round(hct.Hue, MidpointRounding.AwayFromZero) <= 111.0;

        bool chromaPasses = Math.Round(hct.Chroma, MidpointRounding.AwayFromZero) > 16.0;

        bool tonePasses = Math.Round(hct.Tone, MidpointRounding.AwayFromZero) < 65.0;

        return huePasses && chromaPasses && tonePasses;
    }

    /// <summary>
    /// If color is disliked, lighten it to make it likable.
    /// </summary>
    public static HctColor FixIfDisliked(HctColor hct)
    {
        if (IsDisliked(hct))
        {
            return HctColor.From(hct.Hue, hct.Chroma, 70.0);
        }

        return hct;
    }
}