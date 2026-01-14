using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialThemeBuilderConversion.SerializationModels;

namespace MaterialTheming.MaterialThemeBuilderConversion;

internal class MaterialThemeBuilderConverter
{
    public static ThemeColors ConvertFromMaterialThemeBuilder(Scheme scheme)
    {
        var themeColors = new ThemeColors()
        {
            //Primary
            Primary = RgbColor.FromHtml(scheme.Primary),
            OnPrimary = RgbColor.FromHtml(scheme.OnPrimary),
            PrimaryContainer = RgbColor.FromHtml(scheme.PrimaryContainer),
            OnPrimaryContainer = RgbColor.FromHtml(scheme.OnPrimaryContainer),
            //Secondary
            Secondary = RgbColor.FromHtml(scheme.Secondary),
            OnSecondary = RgbColor.FromHtml(scheme.OnSecondary),
            SecondaryContainer = RgbColor.FromHtml(scheme.SecondaryContainer),
            OnSecondaryContainer = RgbColor.FromHtml(scheme.OnSecondaryContainer),
            //Tertiary
            Tertiary = RgbColor.FromHtml(scheme.Tertiary),
            OnTertiary = RgbColor.FromHtml(scheme.OnTertiary),
            TertiaryContainer = RgbColor.FromHtml(scheme.TertiaryContainer),
            OnTertiaryContainer = RgbColor.FromHtml(scheme.OnTertiaryContainer),
            //Error
            Error = RgbColor.FromHtml(scheme.Error),
            OnError = RgbColor.FromHtml(scheme.OnError),
            ErrorContainer = RgbColor.FromHtml(scheme.ErrorContainer),
            OnErrorContainer = RgbColor.FromHtml(scheme.OnErrorContainer),
            //Surface
            Surface = RgbColor.FromHtml(scheme.Surface),
            SurfaceVariant = RgbColor.FromHtml(scheme.SurfaceVariant),
            OnSurface = RgbColor.FromHtml(scheme.OnSurface),
            OnSurfaceVariant = RgbColor.FromHtml(scheme.OnSurfaceVariant),
            SurfaceDim = RgbColor.FromHtml(scheme.SurfaceDim),
            SurfaceBright = RgbColor.FromHtml(scheme.SurfaceBright),
            SurfaceTint = RgbColor.FromHtml(scheme.SurfaceTint),
            //Background
            Background = RgbColor.FromHtml(scheme.Background),
            OnBackground = RgbColor.FromHtml(scheme.OnBackground),
            //Outline
            Outline = RgbColor.FromHtml(scheme.Outline),
            OutlineVariant = RgbColor.FromHtml(scheme.OutlineVariant),
            //Shadow
            Shadow = RgbColor.FromHtml(scheme.Shadow),
            Scrim = RgbColor.FromHtml(scheme.Scrim),
            //Inverse
            InverseSurface = RgbColor.FromHtml(scheme.InverseSurface),
            InverseOnSurface = RgbColor.FromHtml(scheme.InverseOnSurface),
            InversePrimary = RgbColor.FromHtml(scheme.InversePrimary),
            //Primary Fixed
            PrimaryFixed = RgbColor.FromHtml(scheme.PrimaryFixed),
            OnPrimaryFixed = RgbColor.FromHtml(scheme.OnPrimaryFixed),
            PrimaryFixedDim = RgbColor.FromHtml(scheme.PrimaryFixedDim),
            OnPrimaryFixedVariant = RgbColor.FromHtml(scheme.OnPrimaryFixedVariant),
            //Secondary Fixed
            SecondaryFixed = RgbColor.FromHtml(scheme.SecondaryFixed),
            OnSecondaryFixed = RgbColor.FromHtml(scheme.OnSecondaryFixed),
            SecondaryFixedDim = RgbColor.FromHtml(scheme.SecondaryFixedDim),
            OnSecondaryFixedVariant = RgbColor.FromHtml(scheme.OnSecondaryFixedVariant),
            //Tertiary Fixed
            TertiaryFixed = RgbColor.FromHtml(scheme.TertiaryFixed),
            OnTertiaryFixed = RgbColor.FromHtml(scheme.OnTertiaryFixed),
            TertiaryFixedDim = RgbColor.FromHtml(scheme.TertiaryFixedDim),
            OnTertiaryFixedVariant = RgbColor.FromHtml(scheme.OnTertiaryFixedVariant),
            //Surface Container
            SurfaceContainerLowest = RgbColor.FromHtml(scheme.SurfaceContainerLowest),
            SurfaceContainerLow = RgbColor.FromHtml(scheme.SurfaceContainerLow),
            SurfaceContainer = RgbColor.FromHtml(scheme.SurfaceContainer),
            SurfaceContainerHigh = RgbColor.FromHtml(scheme.SurfaceContainerHigh),
            SurfaceContainerHighest = RgbColor.FromHtml(scheme.SurfaceContainerHighest),
        };
        return themeColors;
    }
}
