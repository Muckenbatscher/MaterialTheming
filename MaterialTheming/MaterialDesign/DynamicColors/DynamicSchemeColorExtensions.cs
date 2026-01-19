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
        public HctColor SurfaceVariant => scheme.GetColorSpec().SurfaceVariant.GetHct(scheme);
        public HctColor OnSurface => scheme.GetColorSpec().OnSurface.GetHct(scheme);
        public HctColor OnSurfaceVariant => scheme.GetColorSpec().OnSurfaceVariant.GetHct(scheme);
        public HctColor SurfaceDim => scheme.GetColorSpec().SurfaceDim.GetHct(scheme);
        public HctColor SurfaceBright => scheme.GetColorSpec().SurfaceBright.GetHct(scheme);
        public HctColor SurfaceTint => scheme.GetColorSpec().SurfaceTint.GetHct(scheme);

        public HctColor Background => scheme.GetColorSpec().Background.GetHct(scheme);
        public HctColor OnBackground => scheme.GetColorSpec().OnBackground.GetHct(scheme);

        public HctColor Outline => scheme.GetColorSpec().Outline.GetHct(scheme);
        public HctColor OutlineVariant => scheme.GetColorSpec().OutlineVariant.GetHct(scheme);

        public HctColor Shadow => scheme.GetColorSpec().Shadow.GetHct(scheme);
        public HctColor Scrim => scheme.GetColorSpec().Scrim.GetHct(scheme);

        public HctColor InverseSurface => scheme.GetColorSpec().InverseSurface.GetHct(scheme);
        public HctColor InverseOnSurface => scheme.GetColorSpec().InverseOnSurface.GetHct(scheme);
        public HctColor InversePrimary => scheme.GetColorSpec().InversePrimary.GetHct(scheme);

        public HctColor PrimaryFixed => scheme.GetColorSpec().PrimaryFixed.GetHct(scheme);
        public HctColor OnPrimaryFixed => scheme.GetColorSpec().OnPrimaryFixed.GetHct(scheme);
        public HctColor PrimaryFixedDim => scheme.GetColorSpec().PrimaryFixedDim.GetHct(scheme);
        public HctColor OnPrimaryFixedVariant => scheme.GetColorSpec().OnPrimaryFixedVariant.GetHct(scheme);

        public HctColor SecondaryFixed => scheme.GetColorSpec().SecondaryFixed.GetHct(scheme);
        public HctColor OnSecondaryFixed => scheme.GetColorSpec().OnSecondaryFixed.GetHct(scheme);
        public HctColor SecondaryFixedDim => scheme.GetColorSpec().SecondaryFixedDim.GetHct(scheme);
        public HctColor OnSecondaryFixedVariant => scheme.GetColorSpec().OnSecondaryFixedVariant.GetHct(scheme);

        public HctColor TertiaryFixed => scheme.GetColorSpec().TertiaryFixed.GetHct(scheme);
        public HctColor OnTertiaryFixed => scheme.GetColorSpec().OnTertiaryFixed.GetHct(scheme);
        public HctColor TertiaryFixedDim => scheme.GetColorSpec().TertiaryFixedDim.GetHct(scheme);
        public HctColor OnTertiaryFixedVariant => scheme.GetColorSpec().OnTertiaryFixedVariant.GetHct(scheme);

        public HctColor SurfaceContainerLowest => scheme.GetColorSpec().SurfaceContainerLowest.GetHct(scheme);
        public HctColor SurfaceContainerLow => scheme.GetColorSpec().SurfaceContainerLow.GetHct(scheme);
        public HctColor SurfaceContainer => scheme.GetColorSpec().SurfaceContainer.GetHct(scheme);
        public HctColor SurfaceContainerHigh => scheme.GetColorSpec().SurfaceContainerHigh.GetHct(scheme);
        public HctColor SurfaceContainerHighest => scheme.GetColorSpec().SurfaceContainerHighest.GetHct(scheme);
    }
}
