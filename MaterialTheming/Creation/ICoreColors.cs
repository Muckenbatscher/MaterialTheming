using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.Creation
{
    public interface ICoreColors
    {
        public Color Primary { get; }
        public Color Secondary { get; }
        public Color Tertiary { get; }
        public Color Error { get; }
        public Color Neutral { get; }
        public Color NeutralVariant { get; }
    }
}
