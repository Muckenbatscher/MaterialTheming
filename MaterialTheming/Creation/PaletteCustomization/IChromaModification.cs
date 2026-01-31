namespace MaterialTheming.Creation.PaletteCustomization;

internal interface IChromaModification
{
    Func<double, double>? GetChromaModificationFunction();
}
