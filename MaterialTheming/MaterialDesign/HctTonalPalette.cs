using M2TWinForms.Themes.Creation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.MaterialDesign
{
    public class HctTonalPalette
    {
        public HctTonalPalette(double hue, double chroma)
        {
            var hct = new HctColor(hue, chroma, 0);
            Hue = hct.Hue;
            Chroma = hct.Chroma;
        }
        public HctTonalPalette(HctColor keyColor)
        {
            Hue = keyColor.Hue;
            Chroma = keyColor.Chroma;
        }

        public double Hue { get; private set; }
        public double Chroma { get; private set; }

        public HctColor GetHctForTone(double tone)
        {
            return new HctColor(Hue, Chroma, tone);
        }

        public IColorPalette GetColorPalette()
        {
            var palette = new ColorPalette
            {
                Zero = GetHctForTone(0).GetColor(),
                Ten = GetHctForTone(10).GetColor(),
                Twenty = GetHctForTone(20).GetColor(),
                Thirty = GetHctForTone(30).GetColor(),
                Forty = GetHctForTone(40).GetColor(),
                Fifty = GetHctForTone(50).GetColor(),
                Sixty = GetHctForTone(60).GetColor(),
                Seventy = GetHctForTone(70).GetColor(),
                Eighty = GetHctForTone(80).GetColor(),
                Ninety = GetHctForTone(90).GetColor(),
                NinetyFive = GetHctForTone(95).GetColor(),
                NinetyEight = GetHctForTone(98).GetColor(),
                NinetyNine = GetHctForTone(99).GetColor(),
                Hundred = GetHctForTone(100).GetColor()
            };
            return palette;
        }
    }
}
