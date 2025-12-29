using M2TWinForms.Themes.Creation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.MaterialDesign
{
    public class CoreColors : ICoreColors
    {
        public Color Primary { get; set; }
        public Color Secondary { get; set; }
        public Color Tertiary { get; set; }
        public Color Error { get; set; }
        public Color Neutral { get; set; }
        public Color NeutralVariant { get; set; }
    }
}
