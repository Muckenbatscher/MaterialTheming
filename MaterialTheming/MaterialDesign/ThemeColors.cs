using MaterialTheming.ColorDefinitions;
using MaterialTheming.Creation;

namespace MaterialTheming.MaterialDesign
{
    public class ThemeColors : IThemeColors
    {
        public RgbColor Primary { get; set; } = RgbColor.Empty;
        public RgbColor OnPrimary { get; set; } = RgbColor.Empty;
        public RgbColor PrimaryContainer { get; set; } = RgbColor.Empty;
        public RgbColor OnPrimaryContainer { get; set; } = RgbColor.Empty;
        public RgbColor Secondary { get; set; } = RgbColor.Empty;
        public RgbColor OnSecondary { get; set; } = RgbColor.Empty;
        public RgbColor SecondaryContainer { get; set; } = RgbColor.Empty;
        public RgbColor OnSecondaryContainer { get; set; } = RgbColor.Empty;
        public RgbColor Tertiary { get; set; } = RgbColor.Empty;
        public RgbColor OnTertiary { get; set; } = RgbColor.Empty;
        public RgbColor TertiaryContainer { get; set; } = RgbColor.Empty;
        public RgbColor OnTertiaryContainer { get; set; } = RgbColor.Empty;
        public RgbColor Error { get; set; } = RgbColor.Empty;
        public RgbColor OnError { get; set; } = RgbColor.Empty;
        public RgbColor ErrorContainer { get; set; } = RgbColor.Empty;
        public RgbColor OnErrorContainer { get; set; } = RgbColor.Empty;
        public RgbColor Surface { get; set; } = RgbColor.Empty;
        public RgbColor SurfaceContainer { get; set; } = RgbColor.Empty;
        public RgbColor SurfaceContainerLowest { get; set; } = RgbColor.Empty;
        public RgbColor SurfaceContainerLow { get; set; } = RgbColor.Empty;
        public RgbColor SurfaceContainerHigh { get; set; } = RgbColor.Empty;
        public RgbColor SurfaceContainerHighest { get; set; } = RgbColor.Empty;
        public RgbColor OnSurface { get; set; } = RgbColor.Empty;
        public RgbColor OnSurfaceVariant { get; set; } = RgbColor.Empty;
    }
}
