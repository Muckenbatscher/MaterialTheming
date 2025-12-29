using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.Creation
{
    public interface IColorPalette
    {
        public Color Zero { get; }
        public Color Ten { get; }
        public Color Twenty { get; }
        public Color Thirty { get; }
        public Color Forty { get; }
        public Color Fifty { get; }
        public Color Sixty { get; }
        public Color Seventy { get; }
        public Color Eighty { get; }
        public Color Ninety { get; }
        public Color NinetyFive { get; }
        public Color NinetyEight { get; }
        public Color NinetyNine { get; }
        public Color Hundred { get; }
    }
}
