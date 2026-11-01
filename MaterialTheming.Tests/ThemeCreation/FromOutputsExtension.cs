using MaterialTheming.Tests.TestThemeTypeDiscovery.JsonSerialization;

namespace MaterialTheming.Tests.ThemeCreation;

internal static class FromOutputsExtension
{
    extension(Outputs outputs)
    {
        public ThemeColors CreateThemeColors()
        {
            return new()
            {
                Primary = RgbColor.FromHtml(outputs.Primary),
                OnPrimary = RgbColor.FromHtml(outputs.OnPrimary),
                PrimaryContainer = RgbColor.FromHtml(outputs.PrimaryContainer),
                OnPrimaryContainer = RgbColor.FromHtml(outputs.OnPrimaryContainer),
                Secondary = RgbColor.FromHtml(outputs.Secondary),
                OnSecondary = RgbColor.FromHtml(outputs.OnSecondary),
                SecondaryContainer = RgbColor.FromHtml(outputs.SecondaryContainer),
                OnSecondaryContainer = RgbColor.FromHtml(outputs.OnSecondaryContainer),
                Tertiary = RgbColor.FromHtml(outputs.Tertiary),
                OnTertiary = RgbColor.FromHtml(outputs.OnTertiary),
                TertiaryContainer = RgbColor.FromHtml(outputs.TertiaryContainer),
                OnTertiaryContainer = RgbColor.FromHtml(outputs.OnTertiaryContainer),
                Error = RgbColor.FromHtml(outputs.Error),
                OnError = RgbColor.FromHtml(outputs.OnError),
                ErrorContainer = RgbColor.FromHtml(outputs.ErrorContainer),
                OnErrorContainer = RgbColor.FromHtml(outputs.OnErrorContainer),
                Surface = RgbColor.FromHtml(outputs.Surface),
                SurfaceVariant = RgbColor.FromHtml(outputs.SurfaceVariant),
                OnSurface = RgbColor.FromHtml(outputs.OnSurface),
                OnSurfaceVariant = RgbColor.FromHtml(outputs.OnSurfaceVariant),
                SurfaceDim = RgbColor.FromHtml(outputs.SurfaceDim),
                SurfaceBright = RgbColor.FromHtml(outputs.SurfaceBright),
                SurfaceTint = RgbColor.FromHtml(outputs.SurfaceTint),
                Background = RgbColor.FromHtml(outputs.Background),
                OnBackground = RgbColor.FromHtml(outputs.OnBackground),
                Outline = RgbColor.FromHtml(outputs.Outline),
                OutlineVariant = RgbColor.FromHtml(outputs.OutlineVariant),
                Shadow = RgbColor.FromHtml(outputs.Shadow),
                Scrim = RgbColor.FromHtml(outputs.Scrim),
                InverseSurface = RgbColor.FromHtml(outputs.InverseSurface),
                InverseOnSurface = RgbColor.FromHtml(outputs.InverseOnSurface),
                InversePrimary = RgbColor.FromHtml(outputs.InversePrimary),
                PrimaryFixed = RgbColor.FromHtml(outputs.PrimaryFixed),
                OnPrimaryFixed = RgbColor.FromHtml(outputs.OnPrimaryFixed),
                PrimaryFixedDim = RgbColor.FromHtml(outputs.PrimaryFixedDim),
                OnPrimaryFixedVariant = RgbColor.FromHtml(outputs.OnPrimaryFixedVariant),
                SecondaryFixed = RgbColor.FromHtml(outputs.SecondaryFixed),
                OnSecondaryFixed = RgbColor.FromHtml(outputs.OnSecondaryFixed),
                SecondaryFixedDim = RgbColor.FromHtml(outputs.SecondaryFixedDim),
                OnSecondaryFixedVariant = RgbColor.FromHtml(outputs.OnSecondaryFixedVariant),
                TertiaryFixed = RgbColor.FromHtml(outputs.TertiaryFixed),
                OnTertiaryFixed = RgbColor.FromHtml(outputs.OnTertiaryFixed),
                TertiaryFixedDim = RgbColor.FromHtml(outputs.TertiaryFixedDim),
                OnTertiaryFixedVariant = RgbColor.FromHtml(outputs.OnTertiaryFixedVariant),
                SurfaceContainerLowest = RgbColor.FromHtml(outputs.SurfaceContainerLowest),
                SurfaceContainerLow = RgbColor.FromHtml(outputs.SurfaceContainerLow),
                SurfaceContainer = RgbColor.FromHtml(outputs.SurfaceContainer),
                SurfaceContainerHigh = RgbColor.FromHtml(outputs.SurfaceContainerHigh),
                SurfaceContainerHighest = RgbColor.FromHtml(outputs.SurfaceContainerHighest),
            };
        }
    }
}
