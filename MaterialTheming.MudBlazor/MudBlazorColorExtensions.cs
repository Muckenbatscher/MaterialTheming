using MudBlazor.Utilities;

namespace MaterialTheming;

public static class MudBlazorColorExtensions
{
    extension(RgbColor rgbColor)
    {
        public MudColor ToMudColor()
        {
            return new MudColor(r: rgbColor.Red, g: rgbColor.Green, b: rgbColor.Blue, a: byte.MaxValue);
        }
    }

    extension(HctColor hctColor)
    {
        public MudColor ToColor() => hctColor.ToRgbColor().ToMudColor();
    }

    extension(MudColor color)
    {
        public RgbColor ToRgbColor()
        {
            return RgbColor.FromRgb(color.R, color.G, color.B);
        }
        public HctColor ToHctColor() => color.ToRgbColor().ToHct();
    }
}