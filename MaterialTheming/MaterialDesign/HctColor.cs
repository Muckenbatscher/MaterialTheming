using M2TWinForms.Themes.MaterialDesign.HctConversion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.MaterialDesign
{
    public class HctColor
    {
        private double _hue;
        public double Hue 
        {
            get => _hue;
            set => _hue = (value % 360 + 360) % 360;
        }
        private double _chroma;
        public double Chroma 
        { 
            get => _chroma;
            set => _chroma = Math.Max(Math.Min(value, 120), 0);
        }
        private double _tone;
        public double Tone 
        {
            get => _tone;
            set => _tone = Math.Max(Math.Min(value, 100), 0);
        }

        public HctColor(double hue, double chroma, double tone)
        {
            Hue = hue;
            Chroma = chroma;
            Tone = tone;
        }

        public HctColor(Color rgbColor)
        {
            var hct = Hct.FromInt(rgbColor.ToArgb());
            Hue = hct.Hue;
            Chroma = hct.Chroma;
            Tone = hct.Tone;
        }

        public Color GetColor()
        {
            var hct = Hct.From(Hue, Chroma, Tone);
            return hct.ToColor();
        }
    }
}
