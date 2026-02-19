namespace MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;

internal class ColorSpecFactory
{
    public static IColorSpec Create(SpecVersion version)
    {
        return version switch
        {
            SpecVersion.Spec2021 => new ColorSpec2021(),
            SpecVersion.Spec2025 => new ColorSpec2025(),
            SpecVersion.Spec2026 => new ColorSpec2026(),
            _ => throw new ArgumentOutOfRangeException(nameof(version), $"Unsupported SpecVersion: {version}"),
        };
    }
}
