using MudBlazor;

namespace MaterialTheming;

/// <summary>
/// Provides extension methods for creating a <see cref="Palette"/>
/// from a pre-configured <see cref="IColorPaletteThemeBuilder"/>.
/// </summary>
public static class MudPaletteExtensions
{
    extension(ThemeColors themeColors)
    {
        /// <summary>
        /// Apply the colors from this <see cref="ThemeColors"/> object 
        /// to an existing <see cref="Palette"/>.<br/>
        /// The passed <see cref="Palette"/> will be modified in place.
        /// </summary>
        /// <param name="palette">An existing Palette. 
        /// The passed palette will be modified in place.</param>
        public void ApplyToMudPalette(Palette palette)
        {
            palette.Primary = themeColors.Primary.ToMudColor();
            palette.PrimaryContrastText = themeColors.OnPrimary.ToMudColor();
            palette.Secondary = themeColors.Secondary.ToMudColor();
            palette.SecondaryContrastText = themeColors.OnSecondary.ToMudColor();
            palette.Tertiary = themeColors.Tertiary.ToMudColor();
            palette.TertiaryContrastText = themeColors.OnTertiary.ToMudColor();
            palette.Error = themeColors.Error.ToMudColor();
            palette.ErrorContrastText = themeColors.OnError.ToMudColor();
            palette.Background = themeColors.Surface.ToMudColor();
            palette.Surface = themeColors.Surface.ToMudColor();
            palette.TextPrimary = themeColors.OnSurface.ToMudColor();
            palette.TextSecondary = themeColors.OnSurfaceVariant.ToMudColor();
            palette.TextDisabled = themeColors.OnSurfaceVariant.ToMudColor();
            palette.DrawerBackground = themeColors.SurfaceContainer.ToMudColor();
            palette.DrawerText = themeColors.OnSurface.ToMudColor();
            palette.DrawerIcon = themeColors.OnSurface.ToMudColor();
            palette.AppbarBackground = themeColors.SurfaceContainerHigh.ToMudColor();
            palette.AppbarText = themeColors.OnSurface.ToMudColor();
            palette.TableLines = themeColors.Outline.ToMudColor();
            palette.LinesDefault = themeColors.Outline.ToMudColor();
            palette.LinesInputs = themeColors.Outline.ToMudColor();
            palette.Divider = themeColors.Outline.ToMudColor();
            palette.DividerLight = themeColors.OutlineVariant.ToMudColor();
        }
    }
}
