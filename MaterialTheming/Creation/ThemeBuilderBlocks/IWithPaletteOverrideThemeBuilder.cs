namespace MaterialTheming;

public interface IWithPaletteOverrideThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the override for the primary palette when building the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="paletteOverride">Callback to configure the primary palette.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified override for the primary palette.</returns>
    TBuilder WithPrimaryPalette(Action<IPaletteOverride> paletteOverride);
    /// <summary>
    /// Specify the override for the secondary palette when building the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="paletteOverride">Callback to configure the secondary palette.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified override for the secondary palette.</returns>
    TBuilder WithSecondaryPalette(Action<IPaletteOverride> paletteOverride);
    /// <summary>
    /// Specify the override for the tertiary palette when building the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="paletteOverride">Callback to configure the tertiary palette.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified override for the tertiary palette.</returns>
    TBuilder WithTertiaryPalette(Action<IPaletteOverride> paletteOverride);
    /// <summary>
    /// Specify the override for the error palette when building the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="paletteOverride">Callback to configure the error palette.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified override for the error palette.</returns>
    TBuilder WithErrorPalette(Action<IPaletteOverride> paletteOverride);
    /// <summary>
    /// Specify the override for the neutral palette when building the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="paletteOverride">Callback to configure the neutral palette.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified override for the neutral palette.</returns>
    TBuilder WithNeutralPalette(Action<IPaletteOverride> paletteOverride);
    /// <summary>
    /// Specify the override for the neutral variant palette when building the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="paletteOverride">Callback to configure the neutral variant palette.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified override for the neutral variant palette.</returns>
    TBuilder WithNeutralVariantPalette(Action<IPaletteOverride> paletteOverride);
}
