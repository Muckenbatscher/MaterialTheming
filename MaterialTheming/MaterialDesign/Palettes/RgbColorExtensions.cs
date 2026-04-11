namespace MaterialTheming.MaterialDesign.Palettes;

internal static class RgbColorExtensions
{
    extension(RgbColor)
    {
        public static RgbColor AverageColor(RgbColor colorOne, RgbColor colorTwo)
        {
            var averageRed = GetAverageComponent(colorOne.Red, colorTwo.Red);
            var averageGreen = GetAverageComponent(colorOne.Green, colorTwo.Green);
            var averageBlue = GetAverageComponent(colorOne.Blue, colorTwo.Blue);
            return RgbColor.FromRgb(averageRed, averageGreen, averageBlue);
        }
        private static byte GetAverageComponent(byte componentOne, byte componentTwo)
        {
            // MidpointRounding.AwayFromZero - To ensure that .5 always rounds up to the next integer (like in Java)
            return (byte)Math.Round((componentOne + componentTwo) / 2.0, MidpointRounding.AwayFromZero);
        }
    }
}
