using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal static class DynamicSchemeColorExtensions
{
    extension(DynamicScheme scheme)
    {
        HctColor Primary => ColorSpec2025.Primary.GetHct(scheme);
        HctColor OnPrimary => ColorSpec2025.OnPrimary.GetHct(scheme);
        HctColor PrimaryContainer => ColorSpec2025.PrimaryContainer.GetHct(scheme);
        HctColor OnPrimaryContainer => ColorSpec2025.OnPrimaryContainer.GetHct(scheme);

        HctColor Secondary => ColorSpec2025.Secondary.GetHct(scheme);
        HctColor OnSecondary => ColorSpec2025.OnSecondary.GetHct(scheme);
        HctColor SecondaryContainer => ColorSpec2025.SecondaryContainer.GetHct(scheme);
        HctColor OnSecondaryContainer => ColorSpec2025.OnSecondaryContainer.GetHct(scheme);

        HctColor Tertiary => ColorSpec2025.Tertiary.GetHct(scheme);
        HctColor OnTertiary => ColorSpec2025.OnTertiary.GetHct(scheme);
        HctColor TertiaryContainer => ColorSpec2025.TertiaryContainer.GetHct(scheme);
        HctColor OnTertiaryContainer => ColorSpec2025.OnTertiaryContainer.GetHct(scheme);

        HctColor Error => ColorSpec2025.Error.GetHct(scheme);
        HctColor OnError => ColorSpec2025.OnError.GetHct(scheme);
        HctColor ErrorContainer => ColorSpec2025.ErrorContainer.GetHct(scheme);
        HctColor OnErrorContainer => ColorSpec2025.OnErrorContainer.GetHct(scheme);

        HctColor Surface => ColorSpec2025.Surface.GetHct(scheme);
        HctColor OnSurface => ColorSpec2025.OnSurface.GetHct(scheme);
        HctColor OnSurfaceVariant => ColorSpec2025.OnSurfaceVariant.GetHct(scheme);

        HctColor SurfaceContainerLowest => ColorSpec2025.SurfaceContainerLowest.GetHct(scheme);
        HctColor SurfaceContainerLow => ColorSpec2025.SurfaceContainerLow.GetHct(scheme);
        HctColor SurfaceContainer => ColorSpec2025.SurfaceContainer.GetHct(scheme);
        HctColor SurfaceContainerHigh => ColorSpec2025.SurfaceContainerHigh.GetHct(scheme);
        HctColor SurfaceContainerHighest => ColorSpec2025.SurfaceContainerHighest.GetHct(scheme);
    }
}
