using MaterialTheming.MaterialDesign;

namespace MaterialTheming
{
    public class Theme
    {
        public Theme()
        {
        }

        public Theme(bool isDark, ThemeColors colors)
        {
            IsDark = isDark;
            Colors = colors;
        }

        public bool IsDark { get; set; }
        public ThemeColors Colors { get; set; } = new ThemeColors();
    }
}
