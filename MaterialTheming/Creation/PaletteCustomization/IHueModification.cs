namespace MaterialTheming.Creation.PaletteCustomization;

internal interface IHueModification
{
    Func<double, double>? GetHueModificationFunction();
}
