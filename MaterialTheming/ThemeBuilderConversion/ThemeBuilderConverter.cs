using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;
using MaterialTheming.ThemeBuilderConversion.SerializationModels;

namespace MaterialTheming.ThemeBuilderConversion
{
    internal class ThemeBuilderConverter
    {
        public ThemeColors ConvertFromThemeBuilder(Scheme scheme)
        {
            var themeColors = new ThemeColors()
            {
                Primary = RgbColor.FromHtml(scheme.Primary),
                OnPrimary = RgbColor.FromHtml(scheme.OnPrimary),
                PrimaryContainer = RgbColor.FromHtml(scheme.PrimaryContainer),
                OnPrimaryContainer = RgbColor.FromHtml(scheme.OnPrimaryContainer),

                Secondary = RgbColor.FromHtml(scheme.Secondary),
                OnSecondary = RgbColor.FromHtml(scheme.OnSecondary),
                SecondaryContainer = RgbColor.FromHtml(scheme.SecondaryContainer),
                OnSecondaryContainer = RgbColor.FromHtml(scheme.OnSecondaryContainer),

                Tertiary = RgbColor.FromHtml(scheme.Tertiary),
                OnTertiary = RgbColor.FromHtml(scheme.OnTertiary),
                TertiaryContainer = RgbColor.FromHtml(scheme.TertiaryContainer),
                OnTertiaryContainer = RgbColor.FromHtml(scheme.OnTertiaryContainer),

                Error = RgbColor.FromHtml(scheme.Error),
                OnError = RgbColor.FromHtml(scheme.OnError),
                ErrorContainer = RgbColor.FromHtml(scheme.ErrorContainer),
                OnErrorContainer = RgbColor.FromHtml(scheme.OnErrorContainer),

                Surface = RgbColor.FromHtml(scheme.Surface),
                SurfaceContainer = RgbColor.FromHtml(scheme.SurfaceContainer),
                SurfaceContainerLowest = RgbColor.FromHtml(scheme.SurfaceContainerLowest),
                SurfaceContainerLow = RgbColor.FromHtml(scheme.SurfaceContainerLow),
                SurfaceContainerHigh = RgbColor.FromHtml(scheme.SurfaceContainerHigh),
                SurfaceContainerHighest = RgbColor.FromHtml(scheme.SurfaceContainerHighest),
                OnSurface = RgbColor.FromHtml(scheme.OnSurface),
                OnSurfaceVariant = RgbColor.FromHtml(scheme.OnSurfaceVariant)
            };
            return themeColors;
        }
    }
}
