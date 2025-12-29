using MaterialTheming.Creation;
using MaterialTheming.MaterialDesign;

namespace MaterialTheming
{
    public partial class Theme
    {
        public static Theme CreateFromThemeColors(bool isDark, IThemeColors themeColors)
        {
            var colors = new ThemeColors()
            {
                Primary = themeColors.Primary,
                OnPrimary = themeColors.OnPrimary,
                PrimaryContainer = themeColors.PrimaryContainer,
                OnPrimaryContainer = themeColors.OnPrimaryContainer,
                Secondary = themeColors.Secondary,
                OnSecondary = themeColors.OnSecondary,
                SecondaryContainer = themeColors.SecondaryContainer,
                OnSecondaryContainer = themeColors.OnSecondaryContainer,
                Tertiary = themeColors.Tertiary,
                OnTertiary = themeColors.OnTertiary,
                TertiaryContainer = themeColors.TertiaryContainer,
                OnTertiaryContainer = themeColors.OnTertiaryContainer,
                Error = themeColors.Error,
                OnError = themeColors.OnError,
                ErrorContainer = themeColors.ErrorContainer,
                OnErrorContainer = themeColors.OnErrorContainer,
                Surface = themeColors.Surface,
                SurfaceContainer = themeColors.SurfaceContainer,
                SurfaceContainerLowest = themeColors.SurfaceContainerLowest,
                SurfaceContainerLow = themeColors.SurfaceContainerLow,
                SurfaceContainerHigh = themeColors.SurfaceContainerHigh,
                SurfaceContainerHighest = themeColors.SurfaceContainerHighest,
                OnSurface = themeColors.OnSurface,
                OnSurfaceVariant = themeColors.OnSurfaceVariant
            };
            return new Theme()
            {
                Colors = colors,
                IsDark = isDark,
            };
        }

    }
}
