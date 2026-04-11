namespace MaterialTheming.MaterialDesign.Palettes;

internal static class RgbColorExtensions
{
    extension(RgbColor)
    {
        public static RgbColor AverageColor(RgbColor colorOne, RgbColor colorTwo)
        {
            var averageRed = (byte)Math.Round((colorOne.Red + colorTwo.Red) / 2.0);
            var averageGreen = (byte)Math.Round((colorOne.Green + colorTwo.Green) / 2.0);
            var averageBlue = (byte)Math.Round((colorOne.Blue + colorTwo.Blue) / 2.0);
            return RgbColor.FromRgb(averageRed, averageGreen, averageBlue);
        }
    }
}
