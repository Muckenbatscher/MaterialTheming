using M2TWinForms.Themes.Creation;
using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeProviders
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
