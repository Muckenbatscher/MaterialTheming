namespace MaterialTheming;

public interface IPaletteOverride
{
    /// <summary>
    /// Override the palette generation to use a fixed chroma value.
    /// </summary>
    /// <param name="chroma">The chroma value to override the generated palette's chroma value with. 
    /// Final chroma values might be lower, when the desired chroma is not reachable for the target hue and tone.</param>
    /// <returns>The same instance of <see cref="IPaletteOverride"/> configured with the specified chroma value setting.</returns>
    IPaletteOverride WithChroma(double chroma);
    /// <summary>
    /// Override the palette generation to multiply its generated chroma value.
    /// </summary>
    /// <param name="chromaMultiplier">The multiplier that is applied to the generated palette's chroma value. 
    /// Final chroma values might be lower, when the desired chroma is not reachable for the target hue and tone.</param>
    /// <returns>The same instance of <see cref="IPaletteOverride"/> configured with the specified chroma multiplier setting.</returns>
    IPaletteOverride WithChromaMultiplier(double chromaMultiplier);

    /// <summary>
    /// Override the palette generation to use a fixed hue value.
    /// </summary>
    /// <param name="hue">The hue value to  override the generated palette's chroma value with. 
    /// Value will be sanitized to be in the range between 0 and 360 degrees.</param>
    /// <returns>The same instance of <see cref="IPaletteOverride"/> configured with the specified hue value setting.</returns>
    IPaletteOverride WithHue(double hue);
    /// <summary>
    /// Override the palette generation to shift its generated hue value.
    /// </summary>
    /// <param name="hueShift">The shift on the colorwheel that is applied to the generated palette's hue value. 
    /// After the shift the value will be sanitized to be in the range between 0 and 360 degrees.</param>
    /// <returns>The same instance of <see cref="IPaletteOverride"/> configured with the specified hue shift setting.</returns>
    IPaletteOverride WithHueShift(double hueShift);
}
