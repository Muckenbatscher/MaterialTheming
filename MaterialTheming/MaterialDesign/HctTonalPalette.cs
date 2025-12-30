using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.MaterialDesign
{
    public class HctTonalPalette
    {
        public HctTonalPalette(double hue, double chroma)
        {
            Hue = hue;
            Chroma = chroma;
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
            return HctColor.From(Hue, Chroma, tone);
        }
    }
}
