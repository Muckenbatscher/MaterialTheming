namespace MaterialTheming.ColorDefinitions;

/// <summary>
/// A color representation in the RGB format.
/// <para>
/// Red - The red channel<br/>
/// Green - The green channel<br/>
/// Blue - The blue channel<br/>
/// </para>
/// </summary>
public class RgbColor
{
    /// <summary>
    /// Create a new instance of the <see cref="RgbColor"/> 
    /// with the specified values for the red, green and blue channel.
    /// </summary>
    /// <param name="red">The value for the red channel</param>
    /// <param name="green">The value for the red channel</param>
    /// <param name="blue">The value for the red channel</param>
    /// <returns></returns>
    public static RgbColor FromRgb(byte red, byte green, byte blue)
    {
        return new RgbColor(red, green, blue);
    }
    /// <summary>
    /// Create a new instance of the <see cref="RgbColor"/> from the specified color in ARGB representation.<br/>
    /// Note that the alpha channel will not be preserved.
    /// </summary>
    /// <param name="argb">The color in ARGB representation</param>
    /// <returns><see cref="RgbColor"/> representation of a color with the specified values for the red, green and blue channel.</returns>
    public static RgbColor FromArgb(int argb)
    {
        var red = (argb >> 16) & 0xFF;
        var green = (argb >> 8) & 0xFF;
        var blue = argb & 0xFF;
        return new RgbColor((byte)red, (byte)green, (byte)blue);
    }
    /// <summary>
    /// Create a new instance of the <see cref="RgbColor"/> from an HTML color representation.
    /// </summary>
    /// <param name="hexString">A color in HTML representation. Use either the format <c>#FFFFFF</c> or <c>FFFFFF</c>.</param>
    /// <returns><see cref="RgbColor"/> representation of a color with the specified values for the red, green and blue channel.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static RgbColor FromHtml(string hexString)
    {
        if (hexString.StartsWith("#"))
            hexString = hexString[1..];
        if (hexString.Length != 6)
            throw new ArgumentException("Hex string must be 6 characters long.", nameof(hexString));
        byte red = Convert.ToByte(hexString[0..2], 16);
        byte green = Convert.ToByte(hexString[2..4], 16);
        byte blue = Convert.ToByte(hexString[4..6], 16);
        return new RgbColor(red, green, blue);
    }
    /// <summary>
    /// #000000
    /// </summary>
    public static RgbColor Empty => new RgbColor(0, 0, 0);

    private RgbColor(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
    /// <summary>
    /// The value of the red channel of this <see cref="RgbColor"/>
    /// </summary>
    public byte Red { get; set; }
    /// <summary>
    /// The value of the green channel of this <see cref="RgbColor"/>
    /// </summary>
    public byte Green { get; set; }
    /// <summary>
    /// The value of the blue channel of this <see cref="RgbColor"/>
    /// </summary>
    public byte Blue { get; set; }

    /// <summary>
    /// The color in ARGB representation.<br/>
    /// Note: the alpha channel will always be a fixed value of 0xFF
    /// </summary>
    /// <returns></returns>
    public int ToArgb()
    {
        byte fixedAlpha = 0xFF;
        return (fixedAlpha << 24) | (Red << 16) | (Green << 8) | Blue;
    }
    /// <summary>
    /// The color in HTML representation.
    /// </summary>
    /// <returns>The HTML representation in the format <c>#FFFFFF</c></returns>
    public string ToHtml()
    {
        return $"#{Red:X2}{Green:X2}{Blue:X2}";
    }

    public override string ToString()
    {
        return $"RGB({Red}, {Green}, {Blue})";
    }

    public static bool operator ==(RgbColor colorOne, RgbColor colorTwo)
    {
        return colorOne.Equals(colorTwo);
    }
    public static bool operator !=(RgbColor colorOne, RgbColor colorTwo)
    {
        return !colorOne.Equals(colorTwo);
    }
    public override bool Equals(object? obj)
    {
        return obj is RgbColor color
            && Red == color.Red
            && Green == color.Green
            && Blue == color.Blue;
    }
    public override int GetHashCode() => HashCode.Combine(Red, Green, Blue);
}
