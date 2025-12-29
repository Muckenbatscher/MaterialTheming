using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes
{
    public partial class Theme
    {
        public string Name { get; set; }
        public bool IsDark { get; set; }
        public ThemeColors Colors { get; set; }
    }
}
