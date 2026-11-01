using MaterialTheming.Tests.TestThemeTypeDiscovery.JsonSerialization;

namespace MaterialTheming.Tests.ThemeCreation;

internal static class FromInputsExtension
{
    extension(Inputs inputs)
    {
        public ThemeColors CreateThemeColors()
        {
            var sourceColor = RgbColor.FromHtml(inputs.Color);
            var variant = FromParsedVariant(inputs.Variant);
            var specVersion = FromParsedSpecVersion(inputs.SpecVersion);
            var platform = FromParsedPlatform(inputs.Platform);
            var mode = FromParsedThemeMode(inputs.IsDark);
            var contrastLevel = FromParsedContrastLevel(inputs.ContrastLevel);

            var builder = ThemeBuilder.CreateFromSourceColor(sourceColor)
                .WithVariant(variant)
                .WithSpecVersion(specVersion)
                .WithPlatform(platform)
                .WithMode(mode)
                .WithContrastLevel(contrastLevel);
            if (inputs.SecondColor is not null)
            {
                var secondSourceColor = RgbColor.FromHtml(inputs.SecondColor);
                builder.WithSecondSourceColor(secondSourceColor);
            }
            return builder.Build();
        }

        private static Variant FromParsedVariant(string variant)
        {
            return variant switch
            {
                "CMF" => Variant.CMF,
                "Content" => Variant.Content,
                "Expressive" => Variant.Expressive,
                "Fidelity" => Variant.Fidelity,
                "FruitSalad" => Variant.FruitSalad,
                "Monochrome" => Variant.Monochrome,
                "Neutral" => Variant.Neutral,
                "Rainbow" => Variant.Rainbow,
                "TonalSpot" => Variant.TonalSpot,
                "Vibrant" => Variant.Vibrant,
                _ => throw new ArgumentException($"Unknown Variant: {variant}")
            };
        }
        private static SpecVersion FromParsedSpecVersion(int specVersion)
        {
            return specVersion switch
            {
                2021 => SpecVersion.Spec2021,
                2025 => SpecVersion.Spec2025,
                2026 => SpecVersion.Spec2026,
                _ => throw new ArgumentException($"Unknown SpecVersion: {specVersion}")
            };
        }
        private static Platform FromParsedPlatform(string platform)
        {
            return platform switch
            {
                "phone" => Platform.Phone,
                "watch" => Platform.Watch,
                _ => throw new ArgumentException($"Unknown Platform: {platform}")
            };
        }
        private static ThemeMode FromParsedThemeMode(bool isDark)
        {
            return isDark ? ThemeMode.Dark : ThemeMode.Light;
        }
        private static ContrastLevel FromParsedContrastLevel(double contrastLevel)
        {
            return contrastLevel switch
            {
                0.0 => ContrastLevel.Normal,
                0.5 => ContrastLevel.Medium,
                1.0 => ContrastLevel.High,
                _ => throw new ArgumentException($"Unknown ContrastLevel: {contrastLevel}")
            };
        }
    }
}
