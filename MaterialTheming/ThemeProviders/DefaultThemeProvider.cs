using MaterialTheming.Creation;

namespace MaterialTheming.ThemeProviders
{
    public abstract class DefaultThemeProvider : IThemeProvider
    {
        public Theme CreateTheme()
        {
            var colors = CreateThemeColors();
            return Theme.CreateFromThemeColors(IsDark, colors);
        }
        protected abstract IThemeColors CreateThemeColors();
        protected abstract bool IsDark { get; }
    }
}
