namespace MaterialTheming.MaterialDesign.DynamicColors;

internal static class PlatformExtensions
{
    extension(Platform platform)
    {
        public bool IsPhone() => platform == Platform.Phone;
        public bool IsWatch() => platform == Platform.Watch;
    }
}
