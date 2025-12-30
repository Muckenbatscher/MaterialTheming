namespace MaterialTheming.ColorDefinitions;

public class RgbColor
{
    public static RgbColor FromRgb(byte red, byte green, byte blue)
    {
        return new RgbColor(red, green, blue);
    }
    public static RgbColor FromArgb(int argb)
    {
        var red = (argb >> 16) & 0xFF;
        var green = (argb >> 8) & 0xFF;
        var blue = argb & 0xFF;
        return new RgbColor((byte)red, (byte)green, (byte)blue);
    }
    public static RgbColor FromHtml(string hexString)
    {
        if (hexString.StartsWith("#"))
            hexString = hexString[1..];
        if (hexString.Length != 6)
            throw new ArgumentException("Hex string must be 6 characters long.", nameof(hexString));
        byte red = Convert.ToByte(hexString.Substring(0, 2), 16);
        byte green = Convert.ToByte(hexString.Substring(2, 2), 16);
        byte blue = Convert.ToByte(hexString.Substring(4, 2), 16);
        return new RgbColor(red, green, blue);
    }

    private RgbColor(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }

    public int ToArgb()
    {
        byte fixedAlpha = 0xFF;
        return (fixedAlpha << 24) | (Red << 16) | (Green << 8) | Blue;
    }

    public override string ToString()
    {
        return $"RGB({Red}, {Green}, {Blue})";
    }
}
