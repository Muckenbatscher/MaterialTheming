using MudBlazor;

namespace MaterialTheming;

/// <summary>
/// Provides extension methods for creating a <see cref="MudTheme"/>
/// from a pre-configured <see cref="IColorPaletteThemeBuilder"/>.
/// </summary>
public static class MudThemeExtensions
{
    extension(IColorPaletteThemeBuilder themeBuilder)
    {
        /// <summary>
        /// Build a <see cref="MudTheme"/> with the <see cref="MudTheme.PaletteLight"/> 
        /// and <see cref="MudTheme.PaletteDark"/> filled with the colors from this 
        /// <see cref="IColorPaletteThemeBuilder"/>.
        /// </summary>
        /// <returns>A <see cref="MudTheme"/> with the <see cref="MudTheme.PaletteLight"/> 
        /// and <see cref="MudTheme.PaletteDark"/> filled.</returns>
        public MudTheme BuildMudTheme()
        {
            var paletteDark = new PaletteDark();
            var darkThemeColors = themeBuilder.WithMode(ThemeMode.Dark).Build();
            darkThemeColors.ApplyToMudPalette(paletteDark);

            var paletteLight = new PaletteLight();
            var lightThemeColors = themeBuilder.WithMode(ThemeMode.Light).Build();
            lightThemeColors.ApplyToMudPalette(paletteLight);

            return new MudTheme()
            {
                PaletteDark = paletteDark,
                PaletteLight = paletteLight,
                LayoutProperties = new LayoutProperties()
            };
        }
    }
}
