using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal static class DynamicSchemeColorExtensions
{
    extension(DynamicScheme scheme)
    {
        private IColorSpec GetColorSpec() => ColorSpecFactory.Create(scheme.ColorSpecVersion);

        public HctColor Primary => scheme.GetColorSpec().Primary.GetHct(scheme);
        public HctColor OnPrimary => scheme.GetColorSpec().OnPrimary.GetHct(scheme);
        public HctColor PrimaryContainer => scheme.GetColorSpec().PrimaryContainer.GetHct(scheme);
        public HctColor OnPrimaryContainer => scheme.GetColorSpec().OnPrimaryContainer.GetHct(scheme);

        public HctColor Secondary => scheme.GetColorSpec().Secondary.GetHct(scheme);
        public HctColor OnSecondary => scheme.GetColorSpec().OnSecondary.GetHct(scheme);
        public HctColor SecondaryContainer => scheme.GetColorSpec().SecondaryContainer.GetHct(scheme);
        public HctColor OnSecondaryContainer => scheme.GetColorSpec().OnSecondaryContainer.GetHct(scheme);

        public HctColor Tertiary => scheme.GetColorSpec().Tertiary.GetHct(scheme);
        public HctColor OnTertiary => scheme.GetColorSpec().OnTertiary.GetHct(scheme);
        public HctColor TertiaryContainer => scheme.GetColorSpec().TertiaryContainer.GetHct(scheme);
        public HctColor OnTertiaryContainer => scheme.GetColorSpec().OnTertiaryContainer.GetHct(scheme);

        public HctColor Error => scheme.GetColorSpec().Error.GetHct(scheme);
        public HctColor OnError => scheme.GetColorSpec().OnError.GetHct(scheme);
        public HctColor ErrorContainer => scheme.GetColorSpec().ErrorContainer.GetHct(scheme);
        public HctColor OnErrorContainer => scheme.GetColorSpec().OnErrorContainer.GetHct(scheme);

        public HctColor Surface => scheme.GetColorSpec().Surface.GetHct(scheme);
        public HctColor OnSurface => scheme.GetColorSpec().OnSurface.GetHct(scheme);
        public HctColor OnSurfaceVariant => scheme.GetColorSpec().OnSurfaceVariant.GetHct(scheme);

        public HctColor SurfaceContainerLowest => scheme.GetColorSpec().SurfaceContainerLowest.GetHct(scheme);
        public HctColor SurfaceContainerLow => scheme.GetColorSpec().SurfaceContainerLow.GetHct(scheme);
        public HctColor SurfaceContainer => scheme.GetColorSpec().SurfaceContainer.GetHct(scheme);
        public HctColor SurfaceContainerHigh => scheme.GetColorSpec().SurfaceContainerHigh.GetHct(scheme);
        public HctColor SurfaceContainerHighest => scheme.GetColorSpec().SurfaceContainerHighest.GetHct(scheme);
    }
}
