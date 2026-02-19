namespace MaterialTheming;

/// <summary>
/// The known variants a Material 3 theme can be built for.
/// </summary>
public enum Variant
{
    /// <summary>
    /// All colors are grayscale, no chroma.
    /// </summary>
    Monochrome,
    /// <summary>
    /// Close to grayscale, a hint of chroma.
    /// </summary>
    Neutral,
    /// <summary>
    /// Pastel tokens, low chroma palettes.<br/>Default Material You theme at 2021 launch.
    /// </summary>
    TonalSpot,
    /// <summary>
    /// Pastel colors, high chroma palettes.<br/>The primary palette's chroma is at maximum.<br/>
    /// Use Fidelity instead if tokens should alter their tone to match the palette vibrancy.
    /// </summary>
    Vibrant,
    /// <summary>
    /// Pastel colors, medium chroma palettes.<br/>The primary palette's hue is different from source color, for variety.
    /// </summary>
    Expressive,
    /// <summary>
    /// Tokens and palettes match source color.<br/>Primary Container is source color, adjusted to ensure contrast with surfaces.<br/>
    /// For example, if source color is black, it is lightened so it doesn't match surfaces in dark mode.<br/>Tertiary palette is complement of source color.
    /// </summary>
    Fidelity,
    /// <summary>
    /// Almost identical to Fidelity.<br/>Tokens and palettes match source color.<br/>
    /// Primary Container is source color, adjusted to ensure contrast with surfaces.<br/>Tertiary palette is analogue of source color.
    /// <br/>Found by dividing color wheel by 6, then finding the 2 colors adjacent to source.<br/>The one that increases hue is used.
    /// </summary>
    Content,
    /// <summary>
    /// A playful theme. The source color's hue does not appear in the theme.
    /// </summary>
    Rainbow,
    /// <summary>
    /// A playful theme. The source color's hue does not appear in the theme.
    /// </summary>
    FruitSalad,
    /// <summary>
    /// A Dynamic Color theme with 2 source colors.
    /// </summary>
    CMF
}
