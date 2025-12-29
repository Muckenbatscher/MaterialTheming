using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeProviders
{
    public interface IThemeProvider
    {
        Theme CreateTheme();
    }
}
