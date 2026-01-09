using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.Contrasts;
using MaterialTheming.MaterialDesign.Dislike;
using MaterialTheming.MaterialDesign.HctConversion;
using MaterialTheming.MaterialDesign.Palettes;
using MaterialTheming.MaterialDesign.Temperature;

namespace MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;

internal class ColorSpec2021 : IColorSpec
{
    // ----------------------------------------------------------------
    // Main Palettes
    // ----------------------------------------------------------------

    public DynamicColor PrimaryPaletteKeyColor => new(
        name: "primary_palette_key_color",
        palette: s => s.PrimaryPalette,
        tone: s => s.PrimaryPalette.KeyColor.Tone
    );
    public DynamicColor SecondaryPaletteKeyColor => new(
        name: "secondary_palette_key_color",
        palette: s => s.SecondaryPalette,
        tone: s => s.SecondaryPalette.KeyColor.Tone
    );

    public DynamicColor TertiaryPaletteKeyColor => new(
        name: "tertiary_palette_key_color",
        palette: s => s.TertiaryPalette,
        tone: s => s.TertiaryPalette.KeyColor.Tone
    );

    public DynamicColor NeutralPaletteKeyColor => new(
        name: "neutral_palette_key_color",
        palette: s => s.NeutralPalette,
        tone: s => s.NeutralPalette.KeyColor.Tone
    );

    public DynamicColor NeutralVariantPaletteKeyColor => new(
        name: "neutral_variant_palette_key_color",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.NeutralVariantPalette.KeyColor.Tone
    );

    public DynamicColor ErrorPaletteKeyColor => new(
        name: "error_palette_key_color",
        palette: s => s.ErrorPalette,
        tone: s => s.ErrorPalette.KeyColor.Tone
    );

    // ----------------------------------------------------------------
    // Surfaces
    // ----------------------------------------------------------------

    public virtual DynamicColor Background => new(
        name: "background",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 6.0 : 98.0,
        isBackground: true
    );

    public virtual DynamicColor OnBackground => new(
        name: "on_background",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 90.0 : 10.0,
        background: s => Background,
        contrastCurve: s => new ContrastCurve(3.0, 3.0, 4.5, 7.0)
    );

    public virtual DynamicColor Surface => new(
        name: "surface",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 6.0 : 98.0,
        isBackground: true
    );

    public virtual DynamicColor SurfaceDim => new(
        name: "surface_dim",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 6.0 : new ContrastCurve(87.0, 87.0, 80.0, 75.0).Get(s.ContrastLevel),
        isBackground: true
    );

    public virtual DynamicColor SurfaceBright => new(
        name: "surface_bright",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? new ContrastCurve(24.0, 24.0, 29.0, 34.0).Get(s.ContrastLevel) : 98.0,
        isBackground: true
    );

    public virtual DynamicColor SurfaceContainerLowest => new(
        name: "surface_container_lowest",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? new ContrastCurve(4.0, 4.0, 2.0, 0.0).Get(s.ContrastLevel) : 100.0,
        isBackground: true
    );

    public virtual DynamicColor SurfaceContainerLow => new(
        name: "surface_container_low",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark
            ? new ContrastCurve(10.0, 10.0, 11.0, 12.0).Get(s.ContrastLevel)
            : new ContrastCurve(96.0, 96.0, 96.0, 95.0).Get(s.ContrastLevel),
        isBackground: true
    );

    public virtual DynamicColor SurfaceContainer => new(
        name: "surface_container",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark
            ? new ContrastCurve(12.0, 12.0, 16.0, 20.0).Get(s.ContrastLevel)
            : new ContrastCurve(94.0, 94.0, 92.0, 90.0).Get(s.ContrastLevel),
        isBackground: true
    );

    public virtual DynamicColor SurfaceContainerHigh => new(
        name: "surface_container_high",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark
            ? new ContrastCurve(17.0, 17.0, 21.0, 25.0).Get(s.ContrastLevel)
            : new ContrastCurve(92.0, 92.0, 88.0, 85.0).Get(s.ContrastLevel),
        isBackground: true
    );

    public virtual DynamicColor SurfaceContainerHighest => new(
        name: "surface_container_highest",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark
            ? new ContrastCurve(22.0, 22.0, 26.0, 30.0).Get(s.ContrastLevel)
            : new ContrastCurve(90.0, 90.0, 84.0, 80.0).Get(s.ContrastLevel),
        isBackground: true
    );

    public virtual DynamicColor OnSurface => new(
        name: "on_surface",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 90.0 : 10.0,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor SurfaceVariant => new(
        name: "surface_variant",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.IsDark ? 30.0 : 90.0,
        isBackground: true
    );

    public virtual DynamicColor OnSurfaceVariant => new(
        name: "on_surface_variant",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.IsDark ? 80.0 : 30.0,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 11.0)
    );

    public virtual DynamicColor InverseSurface => new(
        name: "inverse_surface",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 90.0 : 20.0,
        isBackground: true
    );

    public virtual DynamicColor InverseOnSurface => new(
        name: "inverse_on_surface",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 20.0 : 95.0,
        background: s => InverseSurface,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor Outline => new(
        name: "outline",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.IsDark ? 60.0 : 50.0,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.5, 3.0, 4.5, 7.0)
    );

    public virtual DynamicColor OutlineVariant => new(
        name: "outline_variant",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.IsDark ? 30.0 : 80.0,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5)
    );

    public virtual DynamicColor Shadow => new(
        name: "shadow",
        palette: s => s.NeutralPalette,
        tone: s => 0.0
    );

    public virtual DynamicColor Scrim => new(
        name: "scrim",
        palette: s => s.NeutralPalette,
        tone: s => 0.0
    );

    public virtual DynamicColor SurfaceTint => new(
        name: "surface_tint",
        palette: s => s.PrimaryPalette,
        tone: s => s.IsDark ? 80.0 : 40.0,
        isBackground: true
    );

    // ----------------------------------------------------------------
    // Primaries
    // ----------------------------------------------------------------

    public virtual DynamicColor Primary => new(
        name: "primary",
        palette: s => s.PrimaryPalette,
        tone: s => IsMonochrome(s) ? (s.IsDark ? 100.0 : 0.0) : (s.IsDark ? 80.0 : 40.0),
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 7.0),
        toneDeltaPair: s => new ToneDeltaPair(PrimaryContainer, Primary, 10.0, TonePolarity.Nearer, false)
    );

    public virtual DynamicColor? PrimaryDim => null;

    public virtual DynamicColor OnPrimary => new(
        name: "on_primary",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            if (IsMonochrome(s)) return s.IsDark ? 10.0 : 90.0;
            return s.IsDark ? 20.0 : 100.0;
        },
        background: s => Primary,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor PrimaryContainer => new(
        name: "primary_container",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            if (IsFidelity(s)) return s.PrimaryPalette.KeyColor.Tone;
            if (IsMonochrome(s)) return s.IsDark ? 85.0 : 25.0;
            return s.IsDark ? 30.0 : 90.0;
        },
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(PrimaryContainer, Primary, 10.0, TonePolarity.Nearer, false)
    );

    public virtual DynamicColor OnPrimaryContainer => new(
        name: "on_primary_container",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            if (IsFidelity(s))
            {
                // Note: assuming context where PrimaryContainer is the source color being resolved
                // This requires PrimaryContainer.Tone to be resolvable.
                return ForegroundToneCalculation.ForegroundTone(PrimaryContainer.Tone(s), 4.5);
            }
            if (IsMonochrome(s)) return s.IsDark ? 0.0 : 100.0;
            return s.IsDark ? 90.0 : 30.0;
        },
        background: s => PrimaryContainer,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 11.0)
    );

    public virtual DynamicColor InversePrimary => new(
        name: "inverse_primary",
        palette: s => s.PrimaryPalette,
        tone: s => s.IsDark ? 40.0 : 80.0,
        background: s => InverseSurface,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 7.0)
    );

    // ----------------------------------------------------------------
    // Secondaries
    // ----------------------------------------------------------------

    public virtual DynamicColor Secondary => new(
        name: "secondary",
        palette: s => s.SecondaryPalette,
        tone: s => s.IsDark ? 80.0 : 40.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 7.0),
        toneDeltaPair: s => new ToneDeltaPair(SecondaryContainer, Secondary, 10.0, TonePolarity.Nearer, false)
    );

    public virtual DynamicColor? SecondaryDim => null;

    public virtual DynamicColor OnSecondary => new(
        name: "on_secondary",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            if (IsMonochrome(s)) return s.IsDark ? 10.0 : 100.0;
            return s.IsDark ? 20.0 : 100.0;
        },
        background: s => Secondary,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor SecondaryContainer => new(
        name: "secondary_container",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            double initialTone = s.IsDark ? 30.0 : 90.0;
            if (IsMonochrome(s)) return s.IsDark ? 30.0 : 85.0;
            if (!IsFidelity(s)) return initialTone;

            return FindDesiredChromaByTone(
                s.SecondaryPalette.Hue,
                s.SecondaryPalette.Chroma,
                initialTone,
                !s.IsDark);
        },
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(SecondaryContainer, Secondary, 10.0, TonePolarity.Nearer, false)
    );

    public virtual DynamicColor OnSecondaryContainer => new(
        name: "on_secondary_container",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            if (IsMonochrome(s)) return s.IsDark ? 90.0 : 10.0;
            if (!IsFidelity(s)) return s.IsDark ? 90.0 : 30.0;
            return ForegroundToneCalculation.ForegroundTone(SecondaryContainer.Tone(s), 4.5);
        },
        background: s => SecondaryContainer,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 11.0)
    );

    // ----------------------------------------------------------------
    // Tertiaries
    // ----------------------------------------------------------------

    public virtual DynamicColor Tertiary => new(
        name: "tertiary",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (IsMonochrome(s)) return s.IsDark ? 90.0 : 25.0;
            return s.IsDark ? 80.0 : 40.0;
        },
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 7.0),
        toneDeltaPair: s => new ToneDeltaPair(TertiaryContainer, Tertiary, 10.0, TonePolarity.Nearer, false)
    );

    public virtual DynamicColor? TertiaryDim => null;

    public virtual DynamicColor OnTertiary => new(
        name: "on_tertiary",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (IsMonochrome(s)) return s.IsDark ? 10.0 : 90.0;
            return s.IsDark ? 20.0 : 100.0;
        },
        background: s => Tertiary,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor TertiaryContainer => new(
        name: "tertiary_container",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (IsMonochrome(s)) return s.IsDark ? 60.0 : 49.0;
            if (!IsFidelity(s)) return s.IsDark ? 30.0 : 90.0;

            // Note: In C# HctColor is likely the equivalent of Hct.
            // s.PrimaryPalette.KeyColor is an HctColor? 
            // The original code uses s.sourceColorHct.
            // But sourceColorHct isn't directly on DynamicScheme in the provided implementation.
            // However, the Palette was created from source, so we can use PrimaryPalette.KeyColor.
            // Assuming KeyColor stores the HCT.
            var proposedHct = s.TertiaryPalette.GetHct(s.PrimaryPalette.KeyColor.Tone);
            return DislikeAnalyzer.FixIfDisliked(proposedHct).Tone;
        },
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(TertiaryContainer, Tertiary, 10.0, TonePolarity.Nearer, false)
    );

    public virtual DynamicColor OnTertiaryContainer => new(
        name: "on_tertiary_container",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (IsMonochrome(s)) return s.IsDark ? 0.0 : 100.0;
            if (!IsFidelity(s)) return s.IsDark ? 90.0 : 30.0;
            return ForegroundToneCalculation.ForegroundTone(TertiaryContainer.Tone(s), 4.5);
        },
        background: s => TertiaryContainer,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 11.0)
    );

    // ----------------------------------------------------------------
    // Errors
    // ----------------------------------------------------------------

    public virtual DynamicColor Error => new(
        name: "error",
        palette: s => s.ErrorPalette,
        tone: s => s.IsDark ? 80.0 : 40.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 7.0),
        toneDeltaPair: s => new ToneDeltaPair(ErrorContainer, Error, 10.0, TonePolarity.Nearer, false)
    );

    public virtual DynamicColor? ErrorDim => null;

    public virtual DynamicColor OnError => new(
        name: "on_error",
        palette: s => s.ErrorPalette,
        tone: s => s.IsDark ? 20.0 : 100.0,
        background: s => Error,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor ErrorContainer => new(
        name: "error_container",
        palette: s => s.ErrorPalette,
        tone: s => s.IsDark ? 30.0 : 90.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(ErrorContainer, Error, 10.0, TonePolarity.Nearer, false)
    );

    public virtual DynamicColor OnErrorContainer => new(
        name: "on_error_container",
        palette: s => s.ErrorPalette,
        tone: s =>
        {
            if (IsMonochrome(s)) return s.IsDark ? 90.0 : 10.0;
            return s.IsDark ? 90.0 : 30.0;
        },
        background: s => ErrorContainer,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 11.0)
    );

    // ----------------------------------------------------------------
    // Primary Fixed
    // ----------------------------------------------------------------

    public virtual DynamicColor PrimaryFixed => new(
        name: "primary_fixed",
        palette: s => s.PrimaryPalette,
        tone: s => IsMonochrome(s) ? 40.0 : 90.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(PrimaryFixed, PrimaryFixedDim, 10.0, TonePolarity.Lighter, true)
    );

    public virtual DynamicColor PrimaryFixedDim => new(
        name: "primary_fixed_dim",
        palette: s => s.PrimaryPalette,
        tone: s => IsMonochrome(s) ? 30.0 : 80.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(PrimaryFixed, PrimaryFixedDim, 10.0, TonePolarity.Lighter, true)
    );

    public virtual DynamicColor OnPrimaryFixed => new(
        name: "on_primary_fixed",
        palette: s => s.PrimaryPalette,
        tone: s => IsMonochrome(s) ? 100.0 : 10.0,
        background: s => PrimaryFixedDim,
        secondBackground: s => PrimaryFixed,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor OnPrimaryFixedVariant => new(
        name: "on_primary_fixed_variant",
        palette: s => s.PrimaryPalette,
        tone: s => IsMonochrome(s) ? 90.0 : 30.0,
        background: s => PrimaryFixedDim,
        secondBackground: s => PrimaryFixed,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 11.0)
    );

    // ----------------------------------------------------------------
    // Secondary Fixed
    // ----------------------------------------------------------------

    public virtual DynamicColor SecondaryFixed => new(
        name: "secondary_fixed",
        palette: s => s.SecondaryPalette,
        tone: s => IsMonochrome(s) ? 80.0 : 90.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(SecondaryFixed, SecondaryFixedDim, 10.0, TonePolarity.Lighter, true)
    );

    public virtual DynamicColor SecondaryFixedDim => new(
        name: "secondary_fixed_dim",
        palette: s => s.SecondaryPalette,
        tone: s => IsMonochrome(s) ? 70.0 : 80.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(SecondaryFixed, SecondaryFixedDim, 10.0, TonePolarity.Lighter, true)
    );

    public virtual DynamicColor OnSecondaryFixed => new(
        name: "on_secondary_fixed",
        palette: s => s.SecondaryPalette,
        tone: s => 10.0,
        background: s => SecondaryFixedDim,
        secondBackground: s => SecondaryFixed,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor OnSecondaryFixedVariant => new(
        name: "on_secondary_fixed_variant",
        palette: s => s.SecondaryPalette,
        tone: s => IsMonochrome(s) ? 25.0 : 30.0,
        background: s => SecondaryFixedDim,
        secondBackground: s => SecondaryFixed,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 11.0)
    );

    // ----------------------------------------------------------------
    // Tertiary Fixed
    // ----------------------------------------------------------------

    public virtual DynamicColor TertiaryFixed => new(
        name: "tertiary_fixed",
        palette: s => s.TertiaryPalette,
        tone: s => IsMonochrome(s) ? 40.0 : 90.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(TertiaryFixed, TertiaryFixedDim, 10.0, TonePolarity.Lighter, true)
    );

    public virtual DynamicColor TertiaryFixedDim => new(
        name: "tertiary_fixed_dim",
        palette: s => s.TertiaryPalette,
        tone: s => IsMonochrome(s) ? 30.0 : 80.0,
        isBackground: true,
        background: HighestSurface,
        contrastCurve: s => new ContrastCurve(1.0, 1.0, 3.0, 4.5),
        toneDeltaPair: s => new ToneDeltaPair(TertiaryFixed, TertiaryFixedDim, 10.0, TonePolarity.Lighter, true)
    );

    public virtual DynamicColor OnTertiaryFixed => new(
        name: "on_tertiary_fixed",
        palette: s => s.TertiaryPalette,
        tone: s => IsMonochrome(s) ? 100.0 : 10.0,
        background: s => TertiaryFixedDim,
        secondBackground: s => TertiaryFixed,
        contrastCurve: s => new ContrastCurve(4.5, 7.0, 11.0, 21.0)
    );

    public virtual DynamicColor OnTertiaryFixedVariant => new(
        name: "on_tertiary_fixed_variant",
        palette: s => s.TertiaryPalette,
        tone: s => IsMonochrome(s) ? 90.0 : 30.0,
        background: s => TertiaryFixedDim,
        secondBackground: s => TertiaryFixed,
        contrastCurve: s => new ContrastCurve(3.0, 4.5, 7.0, 11.0)
    );

    // ----------------------------------------------------------------
    // Android-only
    // ----------------------------------------------------------------

    public virtual DynamicColor ControlActivated => new(
        name: "control_activated",
        palette: s => s.PrimaryPalette,
        tone: s => s.IsDark ? 30.0 : 90.0,
        isBackground: true
    );

    public virtual DynamicColor ControlNormal => new(
        name: "control_normal",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.IsDark ? 80.0 : 30.0
    );

    public virtual DynamicColor ControlHighlight => new(
        name: "control_highlight",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 100.0 : 0.0,
        opacity: s => s.IsDark ? 0.20 : 0.12
    );

    public virtual DynamicColor TextPrimaryInverse => new(
        name: "text_primary_inverse",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 10.0 : 90.0
    );

    public virtual DynamicColor TextSecondaryAndTertiaryInverse => new(
        name: "text_secondary_and_tertiary_inverse",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.IsDark ? 30.0 : 80.0
    );

    public virtual DynamicColor TextPrimaryInverseDisableOnly => new(
        name: "text_primary_inverse_disable_only",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 10.0 : 90.0
    );

    public virtual DynamicColor TextSecondaryAndTertiaryInverseDisabled => new(
        name: "text_secondary_and_tertiary_inverse_disabled",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 10.0 : 90.0
    );

    public virtual DynamicColor TextHintInverse => new(
        name: "text_hint_inverse",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 10.0 : 90.0
    );

    // ----------------------------------------------------------------
    // Helpers
    // ----------------------------------------------------------------

    public virtual DynamicColor HighestSurface(DynamicScheme s)
    {
        return s.IsDark ? SurfaceBright : SurfaceDim;
    }

    protected static bool IsFidelity(DynamicScheme scheme)
    {
        return scheme.Variant == Variant.Fidelity || scheme.Variant == Variant.Content;
    }

    protected static bool IsMonochrome(DynamicScheme scheme)
    {
        return scheme.Variant == Variant.Monochrome;
    }

    private static double FindDesiredChromaByTone(double hue, double chroma, double tone, bool byDecreasingTone)
    {
        double answer = tone;
        HctColor closestToChroma = HctColor.From(hue, chroma, tone);

        if (closestToChroma.Chroma < chroma)
        {
            double chromaPeak = closestToChroma.Chroma;
            while (closestToChroma.Chroma < chroma)
            {
                answer += byDecreasingTone ? -1.0 : 1.0;
                HctColor potentialSolution = HctColor.From(hue, chroma, answer);

                if (chromaPeak > potentialSolution.Chroma) break;
                if (Math.Abs(potentialSolution.Chroma - chroma) < 0.4) break;

                double potentialDelta = Math.Abs(potentialSolution.Chroma - chroma);
                double currentDelta = Math.Abs(closestToChroma.Chroma - chroma);

                if (potentialDelta < currentDelta)
                {
                    closestToChroma = potentialSolution;
                }
                chromaPeak = Math.Max(chromaPeak, potentialSolution.Chroma);
            }
        }

        return answer;
    }

    // ----------------------------------------------------------------
    // Calculations
    // ----------------------------------------------------------------

    public virtual HctColor GetHct(DynamicScheme scheme, DynamicColor color)
    {
        double tone = GetTone(scheme, color);
        return color.Palette(scheme).GetHct(tone);
    }

    public virtual double GetTone(DynamicScheme scheme, DynamicColor color)
    {
        bool decreasingContrast = scheme.ContrastLevel < 0;

        // Assuming ToneDeltaPair.Apply(scheme) logic exists or we invoke the Func
        ToneDeltaPair? toneDeltaPair = color.ToneDeltaPair?.Invoke(scheme);

        if (toneDeltaPair != null)
        {
            DynamicColor roleA = toneDeltaPair.RoleA;
            DynamicColor roleB = toneDeltaPair.RoleB;
            double delta = toneDeltaPair.Delta;
            TonePolarity polarity = toneDeltaPair.Polarity;
            bool stayTogether = toneDeltaPair.StayTogether;

            bool aIsNearer = polarity == TonePolarity.Nearer ||
                             (polarity == TonePolarity.Lighter && !scheme.IsDark) ||
                             (polarity == TonePolarity.Darker && !scheme.IsDark);

            DynamicColor nearer = aIsNearer ? roleA : roleB;
            DynamicColor farther = aIsNearer ? roleB : roleA;
            bool amNearer = color.Name == nearer.Name;
            double expansionDir = scheme.IsDark ? 1 : -1;

            double nTone = nearer.Tone(scheme);
            double fTone = farther.Tone(scheme);

            if (color.Background != null && nearer.ContrastCurve != null && farther.ContrastCurve != null)
            {
                DynamicColor? bg = color.Background(scheme);
                ContrastCurve? nContrastCurve = nearer.ContrastCurve(scheme);
                ContrastCurve? fContrastCurve = farther.ContrastCurve(scheme);

                if (bg != null && nContrastCurve != null && fContrastCurve != null)
                {
                    double nContrast = nContrastCurve.Get(scheme.ContrastLevel);
                    double fContrast = fContrastCurve.Get(scheme.ContrastLevel);
                    double bgTone = bg.GetTone(scheme);

                    if (Contrast.RatioOfTones(bgTone, nTone) < nContrast)
                    {
                        nTone = ForegroundToneCalculation.ForegroundTone(bgTone, nContrast);
                    }
                    if (Contrast.RatioOfTones(bgTone, fTone) < fContrast)
                    {
                        fTone = ForegroundToneCalculation.ForegroundTone(bgTone, fContrast);
                    }

                    if (decreasingContrast)
                    {
                        nTone = ForegroundToneCalculation.ForegroundTone(bgTone, nContrast);
                        fTone = ForegroundToneCalculation.ForegroundTone(bgTone, fContrast);
                    }
                }
            }

            if ((fTone - nTone) * expansionDir < delta)
            {
                fTone = Math.Clamp(nTone + delta * expansionDir, 0, 100);
                if ((fTone - nTone) * expansionDir < delta)
                {
                    nTone = Math.Clamp(fTone - delta * expansionDir, 0, 100);
                }
            }

            if (50 <= nTone && nTone < 60)
            {
                if (expansionDir > 0)
                {
                    nTone = 60;
                    fTone = Math.Max(fTone, nTone + delta * expansionDir);
                }
                else
                {
                    nTone = 49;
                    fTone = Math.Min(fTone, nTone + delta * expansionDir);
                }
            }
            else if (50 <= fTone && fTone < 60)
            {
                if (stayTogether)
                {
                    if (expansionDir > 0)
                    {
                        nTone = 60;
                        fTone = Math.Max(fTone, nTone + delta * expansionDir);
                    }
                    else
                    {
                        nTone = 49;
                        fTone = Math.Min(fTone, nTone + delta * expansionDir);
                    }
                }
                else
                {
                    if (expansionDir > 0) fTone = 60;
                    else fTone = 49;
                }
            }

            return amNearer ? nTone : fTone;
        }
        else
        {
            double answer = color.Tone(scheme);

            if (color.Background == null || color.ContrastCurve == null)
            {
                return answer;
            }

            DynamicColor? bg = color.Background(scheme);
            ContrastCurve? curve = color.ContrastCurve(scheme);

            if (bg == null || curve == null) return answer;

            double bgTone = bg.GetTone(scheme);
            double desiredRatio = curve.Get(scheme.ContrastLevel);

            if (Contrast.RatioOfTones(bgTone, answer) < desiredRatio)
            {
                answer = ForegroundToneCalculation.ForegroundTone(bgTone, desiredRatio);
            }

            if (decreasingContrast)
            {
                answer = ForegroundToneCalculation.ForegroundTone(bgTone, desiredRatio);
            }

            if (color.IsBackground && 50 <= answer && answer < 60)
            {
                if (Contrast.RatioOfTones(49, bgTone) >= desiredRatio)
                {
                    answer = 49;
                }
                else
                {
                    answer = 60;
                }
            }

            if (color.SecondBackground == null) return answer;

            DynamicColor? bg2 = color.SecondBackground(scheme);
            if (bg2 == null) return answer;

            double bgTone1 = bgTone;
            double bgTone2 = bg2.GetTone(scheme);

            double upper = Math.Max(bgTone1, bgTone2);
            double lower = Math.Min(bgTone1, bgTone2);

            if (Contrast.RatioOfTones(upper, answer) >= desiredRatio &&
                Contrast.RatioOfTones(lower, answer) >= desiredRatio)
            {
                return answer;
            }

            double lightOption = Contrast.Lighter(upper, desiredRatio);
            double darkOption = Contrast.Darker(lower, desiredRatio);

            List<double> availables = new();
            if (lightOption != -1) availables.Add(lightOption);
            if (darkOption != -1) availables.Add(darkOption);

            bool prefersLight = ForegroundToneCalculation.TonePrefersLightForeground(bgTone1) ||
                                ForegroundToneCalculation.TonePrefersLightForeground(bgTone2);

            if (prefersLight) return lightOption == -1 ? 100 : lightOption;
            if (availables.Count == 1) return availables[0];
            return darkOption == -1 ? 0 : darkOption;
        }
    }

    // ----------------------------------------------------------------
    // Scheme Palettes
    // ----------------------------------------------------------------

    public virtual TonalPalette GetPrimaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Content or Variant.Fidelity => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, sourceColorHct.Chroma),
            Variant.FruitSalad => TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegrees(sourceColorHct.Hue - 50.0), 48.0),
            Variant.Monochrome => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0),
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 12.0),
            Variant.Rainbow => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 48.0),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 36.0),
            Variant.Expressive => TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegrees(sourceColorHct.Hue + 240), 40),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 200.0),
            _ => throw new ArgumentOutOfRangeException(nameof(variant), variant, null)
        };
    }

    public virtual TonalPalette GetSecondaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Content or Variant.Fidelity => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, Math.Max(sourceColorHct.Chroma - 32.0, sourceColorHct.Chroma * 0.5)),
            Variant.FruitSalad => TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegrees(sourceColorHct.Hue - 50.0), 36.0),
            Variant.Monochrome => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0),
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 8.0),
            Variant.Rainbow => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16.0),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16.0),
            Variant.Expressive => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 21, 51, 121, 151, 191, 271, 321, 360], [45, 95, 45, 20, 45, 90, 45, 45, 45]),
                24.0),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 41, 61, 101, 131, 181, 251, 301, 360], [18, 15, 10, 12, 15, 18, 15, 12, 12]),
                24.0),
            _ => throw new ArgumentOutOfRangeException(nameof(variant), variant, null)
        };
    }

    public virtual TonalPalette GetTertiaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Content => TonalPalette.FromHct(DislikeAnalyzer.FixIfDisliked(new TemperatureCache(sourceColorHct).GetAnalogousColors(3, 6)[2])),
            Variant.Fidelity => TonalPalette.FromHct(DislikeAnalyzer.FixIfDisliked(new TemperatureCache(sourceColorHct).GetComplement())),
            Variant.FruitSalad => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 36.0),
            Variant.Monochrome => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0),
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16.0),
            Variant.Rainbow or Variant.TonalSpot => TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegrees(sourceColorHct.Hue + 60.0), 24.0),
            Variant.Expressive => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 21, 51, 121, 151, 191, 271, 321, 360], [120, 120, 20, 45, 20, 15, 20, 120, 120]),
                32.0),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 41, 61, 101, 131, 181, 251, 301, 360], [35, 30, 20, 25, 30, 35, 30, 25, 25]),
                32.0),
            _ => throw new ArgumentOutOfRangeException(nameof(variant), variant, null)
        };
    }

    public virtual TonalPalette GetNeutralPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Content or Variant.Fidelity => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, sourceColorHct.Chroma / 8.0),
            Variant.FruitSalad => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 10.0),
            Variant.Monochrome => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0),
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 2.0),
            Variant.Rainbow => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 6.0),
            Variant.Expressive => TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegrees(sourceColorHct.Hue + 15), 8),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 10),
            _ => throw new ArgumentOutOfRangeException(nameof(variant), variant, null)
        };
    }

    public virtual TonalPalette GetNeutralVariantPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Content or Variant.Fidelity => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, (sourceColorHct.Chroma / 8.0) + 4.0),
            Variant.FruitSalad => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16.0),
            Variant.Monochrome => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0),
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 2.0),
            Variant.Rainbow => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 8.0),
            Variant.Expressive => TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegrees(sourceColorHct.Hue + 15), 12),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 12),
            _ => throw new ArgumentOutOfRangeException(nameof(variant), variant, null)
        };
    }

    public virtual TonalPalette? GetErrorPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return null;
    }
}
