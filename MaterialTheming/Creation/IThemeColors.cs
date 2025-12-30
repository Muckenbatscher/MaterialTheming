using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation
{
    public interface IThemeColors
    {
        public RgbColor Primary { get; }
        public RgbColor OnPrimary { get; }
        public RgbColor PrimaryContainer { get; }
        public RgbColor OnPrimaryContainer { get; }
        public RgbColor Secondary { get; }
        public RgbColor OnSecondary { get; }
        public RgbColor SecondaryContainer { get; }
        public RgbColor OnSecondaryContainer { get; }
        public RgbColor Tertiary { get; }
        public RgbColor OnTertiary { get; }
        public RgbColor TertiaryContainer { get; }
        public RgbColor OnTertiaryContainer { get; }
        public RgbColor Error { get; }
        public RgbColor OnError { get; }
        public RgbColor ErrorContainer { get; }
        public RgbColor OnErrorContainer { get; }
        public RgbColor Surface { get; }
        public RgbColor SurfaceContainer { get; }
        public RgbColor SurfaceContainerLowest { get; }
        public RgbColor SurfaceContainerLow { get; }
        public RgbColor SurfaceContainerHigh { get; }
        public RgbColor SurfaceContainerHighest { get; }
        public RgbColor OnSurface { get; }
        public RgbColor OnSurfaceVariant { get; }
    }
}
