using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal static class DynamicSchemeColorExtensions
{
    extension(DynamicScheme scheme)
    {
        public HctColor Primary => ColorSpec2025.Primary.GetHct(scheme);
        public HctColor OnPrimary => ColorSpec2025.OnPrimary.GetHct(scheme);
        public HctColor PrimaryContainer => ColorSpec2025.PrimaryContainer.GetHct(scheme);
        public HctColor OnPrimaryContainer => ColorSpec2025.OnPrimaryContainer.GetHct(scheme);

        public HctColor Secondary => ColorSpec2025.Secondary.GetHct(scheme);
        public HctColor OnSecondary => ColorSpec2025.OnSecondary.GetHct(scheme);
        public HctColor SecondaryContainer => ColorSpec2025.SecondaryContainer.GetHct(scheme);
        public HctColor OnSecondaryContainer => ColorSpec2025.OnSecondaryContainer.GetHct(scheme);

        public HctColor Tertiary => ColorSpec2025.Tertiary.GetHct(scheme);
        public HctColor OnTertiary => ColorSpec2025.OnTertiary.GetHct(scheme);
        public HctColor TertiaryContainer => ColorSpec2025.TertiaryContainer.GetHct(scheme);
        public HctColor OnTertiaryContainer => ColorSpec2025.OnTertiaryContainer.GetHct(scheme);

        public HctColor Error => ColorSpec2025.Error.GetHct(scheme);
        public HctColor OnError => ColorSpec2025.OnError.GetHct(scheme);
        public HctColor ErrorContainer => ColorSpec2025.ErrorContainer.GetHct(scheme);
        public HctColor OnErrorContainer => ColorSpec2025.OnErrorContainer.GetHct(scheme);

        public HctColor Surface => ColorSpec2025.Surface.GetHct(scheme);
        public HctColor OnSurface => ColorSpec2025.OnSurface.GetHct(scheme);
        public HctColor OnSurfaceVariant => ColorSpec2025.OnSurfaceVariant.GetHct(scheme);

        public HctColor SurfaceContainerLowest => ColorSpec2025.SurfaceContainerLowest.GetHct(scheme);
        public HctColor SurfaceContainerLow => ColorSpec2025.SurfaceContainerLow.GetHct(scheme);
        public HctColor SurfaceContainer => ColorSpec2025.SurfaceContainer.GetHct(scheme);
        public HctColor SurfaceContainerHigh => ColorSpec2025.SurfaceContainerHigh.GetHct(scheme);
        public HctColor SurfaceContainerHighest => ColorSpec2025.SurfaceContainerHighest.GetHct(scheme);
    }
}
