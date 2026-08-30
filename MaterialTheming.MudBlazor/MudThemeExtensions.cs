using MaterialTheming;
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
        /// 
        /// </summary>
        /// <returns>A <see cref="MudTheme"/> with the <see cref="MudTheme.PaletteLight"/> 
        /// and <see cref="MudTheme.PaletteDark"/> filled.</returns>
        public MudTheme BuildMudTheme()
        {
            var paletteDark = new PaletteDark();
            var darkThemeColors = themeBuilder.WithMode(ThemeMode.Dark).Build();
            ApplyMaterialThemeColorsToPalette(darkThemeColors, paletteDark);

            var paletteLight = new PaletteLight();
            var lightThemeColors = themeBuilder.WithMode(ThemeMode.Light).Build();
            ApplyMaterialThemeColorsToPalette(lightThemeColors, paletteLight);

            return new MudTheme()
            {
                PaletteDark = paletteDark,
                PaletteLight = paletteLight,
                LayoutProperties = new LayoutProperties()
            };
        }
    }

    private static void ApplyMaterialThemeColorsToPalette(ThemeColors materialThemeColors, Palette palette)
    {
        palette.Primary = materialThemeColors.Primary.ToMudColor();
        palette.PrimaryContrastText = materialThemeColors.OnPrimary.ToMudColor();
        palette.Secondary = materialThemeColors.Secondary.ToMudColor();
        palette.SecondaryContrastText = materialThemeColors.OnSecondary.ToMudColor();
        palette.Tertiary = materialThemeColors.Tertiary.ToMudColor();
        palette.TertiaryContrastText = materialThemeColors.OnTertiary.ToMudColor();
        palette.Error = materialThemeColors.Error.ToMudColor();
        palette.ErrorContrastText = materialThemeColors.OnError.ToMudColor();
        palette.Background = materialThemeColors.Surface.ToMudColor();
        palette.Surface = materialThemeColors.Surface.ToMudColor();
        palette.TextPrimary = materialThemeColors.OnSurface.ToMudColor();
        palette.TextSecondary = materialThemeColors.OnSurfaceVariant.ToMudColor();
        palette.TextDisabled = materialThemeColors.OnSurfaceVariant.ToMudColor();
        palette.DrawerBackground = materialThemeColors.SurfaceContainer.ToMudColor();
        palette.DrawerText = materialThemeColors.OnSurface.ToMudColor();
        palette.DrawerIcon = materialThemeColors.OnSurface.ToMudColor();
        palette.AppbarBackground = materialThemeColors.SurfaceContainerHigh.ToMudColor();
        palette.AppbarText = materialThemeColors.OnSurface.ToMudColor();
        palette.TableLines = materialThemeColors.Outline.ToMudColor();
        palette.LinesDefault = materialThemeColors.Outline.ToMudColor();
        palette.LinesInputs = materialThemeColors.Outline.ToMudColor();
        palette.Divider = materialThemeColors.Outline.ToMudColor();
        palette.DividerLight = materialThemeColors.OutlineVariant.ToMudColor();
    }
}
