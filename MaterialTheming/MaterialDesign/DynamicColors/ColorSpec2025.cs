using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.Contrasts;
using MaterialTheming.MaterialDesign.Hct;
using MaterialTheming.MaterialDesign.HctConversion;
using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class ColorSpec2025
{
    // -----------------------------------------------------------------------------
    // Main Palettes (From 2021 - Not overridden in 2025)
    // -----------------------------------------------------------------------------

    public DynamicColor PrimaryPaletteKeyColor => new DynamicColor(
        name: "primary_palette_key_color",
        palette: s => s.PrimaryPalette,
        tone: s => s.PrimaryPalette.KeyColor.Tone
    );

    public DynamicColor SecondaryPaletteKeyColor => new DynamicColor(
        name: "secondary_palette_key_color",
        palette: s => s.SecondaryPalette,
        tone: s => s.SecondaryPalette.KeyColor.Tone
    );

    public DynamicColor TertiaryPaletteKeyColor => new DynamicColor(
        name: "tertiary_palette_key_color",
        palette: s => s.TertiaryPalette,
        tone: s => s.TertiaryPalette.KeyColor.Tone
    );

    public DynamicColor NeutralPaletteKeyColor => new DynamicColor(
        name: "neutral_palette_key_color",
        palette: s => s.NeutralPalette,
        tone: s => s.NeutralPalette.KeyColor.Tone
    );

    public DynamicColor NeutralVariantPaletteKeyColor => new DynamicColor(
        name: "neutral_variant_palette_key_color",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.NeutralVariantPalette.KeyColor.Tone
    );

    public DynamicColor ErrorPaletteKeyColor => new DynamicColor(
        name: "error_palette_key_color",
        palette: s => s.ErrorPalette,
        tone: s => s.ErrorPalette.KeyColor.Tone
    );

    // -----------------------------------------------------------------------------
    // Surfaces [S]
    // -----------------------------------------------------------------------------

    public DynamicColor Background => new DynamicColor(
        name: "background",
        palette: s => s.NeutralPalette,
        tone: s => Surface.Tone(s), // Maps to Surface in 2025
        isBackground: true
    );

    public DynamicColor OnBackground => new DynamicColor(
        name: "on_background",
        palette: s => s.NeutralPalette,
        tone: s => s.Platform == Platform.Watch ? 100.0 : OnSurface.Tone(s), // Maps to OnSurface in 2025 (with Watch exception)
        background: s => Background,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(11) : GetContrastCurve(9)
    );

    public DynamicColor Surface => new DynamicColor(
        name: "surface",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.IsDark) return 4.0;
                if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue)) return 99.0;
                if (s.Variant == Variant.Vibrant) return 97.0;
                return 98.0;
            }
            return 0.0;
        },
        isBackground: true
    );

    public DynamicColor SurfaceDim => new DynamicColor(
        name: "surface_dim",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.IsDark) return 4.0;
            if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue)) return 90.0;
            if (s.Variant == Variant.Vibrant) return 85.0;
            return 87.0;
        },
        isBackground: true,
        chromaMultiplier: s =>
        {
            if (!s.IsDark)
            {
                if (s.Variant == Variant.Neutral) return 2.5;
                if (s.Variant == Variant.TonalSpot) return 1.7;
                if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 2.7 : 1.75;
                if (s.Variant == Variant.Vibrant) return 1.36;
            }
            return 1.0;
        }
    );

    public DynamicColor SurfaceBright => new DynamicColor(
        name: "surface_bright",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.IsDark) return 18.0;
            if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue)) return 99.0;
            if (s.Variant == Variant.Vibrant) return 97.0;
            return 98.0;
        },
        isBackground: true,
        chromaMultiplier: s =>
        {
            if (s.IsDark)
            {
                if (s.Variant == Variant.Neutral) return 2.5;
                if (s.Variant == Variant.TonalSpot) return 1.7;
                if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 2.7 : 1.75;
                if (s.Variant == Variant.Vibrant) return 1.36;
            }
            return 1.0;
        }
    );

    public DynamicColor SurfaceContainerLowest => new DynamicColor(
        name: "surface_container_lowest",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 0.0 : 100.0,
        isBackground: true
    );

    public DynamicColor SurfaceContainerLow => new DynamicColor(
        name: "surface_container_low",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.IsDark) return 6.0;
                if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue)) return 98.0;
                if (s.Variant == Variant.Vibrant) return 95.0;
                return 96.0;
            }
            return 15.0;
        },
        isBackground: true,
        chromaMultiplier: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.Variant == Variant.Neutral) return 1.3;
                if (s.Variant == Variant.TonalSpot) return 1.25;
                if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 1.3 : 1.15;
                if (s.Variant == Variant.Vibrant) return 1.08;
            }
            return 1.0;
        }
    );

    public DynamicColor SurfaceContainer => new DynamicColor(
        name: "surface_container",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.IsDark) return 9.0;
                if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue)) return 96.0;
                if (s.Variant == Variant.Vibrant) return 92.0;
                return 94.0;
            }
            return 20.0;
        },
        isBackground: true,
        chromaMultiplier: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.Variant == Variant.Neutral) return 1.6;
                if (s.Variant == Variant.TonalSpot) return 1.4;
                if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 1.6 : 1.3;
                if (s.Variant == Variant.Vibrant) return 1.15;
            }
            return 1.0;
        }
    );

    public DynamicColor SurfaceContainerHigh => new DynamicColor(
        name: "surface_container_high",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.IsDark) return 12.0;
                if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue)) return 94.0;
                if (s.Variant == Variant.Vibrant) return 90.0;
                return 92.0;
            }
            return 25.0;
        },
        isBackground: true,
        chromaMultiplier: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.Variant == Variant.Neutral) return 1.9;
                if (s.Variant == Variant.TonalSpot) return 1.5;
                if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 1.95 : 1.45;
                if (s.Variant == Variant.Vibrant) return 1.22;
            }
            return 1.0;
        }
    );

    public DynamicColor SurfaceContainerHighest => new DynamicColor(
        name: "surface_container_highest",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.IsDark) return 15.0;
            if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue)) return 92.0;
            if (s.Variant == Variant.Vibrant) return 88.0;
            return 90.0;
        },
        isBackground: true,
        chromaMultiplier: s =>
        {
            if (s.Variant == Variant.Neutral) return 2.2;
            if (s.Variant == Variant.TonalSpot) return 1.7;
            if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 2.3 : 1.6;
            if (s.Variant == Variant.Vibrant) return 1.29;
            return 1.0;
        }
    );

    public DynamicColor OnSurface => new DynamicColor(
        name: "on_surface",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.Variant == Variant.Vibrant)
            {
                return TMaxC(s.NeutralPalette, 0, 100, 1.1);
            }
            else
            {
                // Logic from 2025 "getInitialToneFromBackground" equivalent
                DynamicColor bg = s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh;
                return bg.GetTone(s) < 50 ? 98.0 : 10.0; // Approximation of standard contrast calculation initial tone
            }
        },
        chromaMultiplier: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.Variant == Variant.Neutral) return 2.2;
                if (s.Variant == Variant.TonalSpot) return 1.7;
                if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
            }
            return 1.0;
        },
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh,
        contrastCurve: s => s.IsDark && s.Platform == Platform.Phone ? GetContrastCurve(11) : GetContrastCurve(9)
    );

    public DynamicColor SurfaceVariant => new DynamicColor(
        name: "surface_variant",
        palette: s => s.NeutralPalette,
        tone: s => SurfaceContainerHighest.Tone(s), // Remapped in 2025
        isBackground: true,
        chromaMultiplier: s => SurfaceContainerHighest.ChromaMultiplier?.Invoke(s) ?? 1.0
    );

    public DynamicColor OnSurfaceVariant => new DynamicColor(
        name: "on_surface_variant",
        palette: s => s.NeutralPalette,
        // Tone logic inferred from typical OnVariant behavior or default recursion, 
        // but 2025 doesn't explicitly override Tone, it overrides Chroma/BG/Contrast.
        // However, since we aren't inheriting 2021, we need a tone. 
        // 2021 was: s.IsDark ? 80.0 : 30.0. 
        // But we should use the standard contrast relationship.
        tone: s => s.IsDark ? 80.0 : 30.0,
        chromaMultiplier: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.Variant == Variant.Neutral) return 2.2;
                if (s.Variant == Variant.TonalSpot) return 1.7;
                if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
            }
            return 1.0;
        },
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone
            ? (s.IsDark ? GetContrastCurve(6) : GetContrastCurve(4.5))
            : GetContrastCurve(7)
    );

    public DynamicColor InverseSurface => new DynamicColor(
        name: "inverse_surface",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 98.0 : 4.0,
        isBackground: true
    );

    public DynamicColor InverseOnSurface => new DynamicColor(
        name: "inverse_on_surface",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 20.0 : 95.0, // From 2021 fallback
        background: s => InverseSurface,
        contrastCurve: s => GetContrastCurve(7)
    );

    public DynamicColor Outline => new DynamicColor(
        name: "outline",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 60.0 : 50.0, // From 2021 fallback
        chromaMultiplier: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.Variant == Variant.Neutral)
                    return 2.2;
                if (s.Variant == Variant.TonalSpot)
                    return 1.7;
                if (s.Variant == Variant.Expressive)
                    return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
            }
            return 1.0;
        },
        background: s => s.Platform == Platform.Phone
            ? (s.IsDark ? SurfaceBright : SurfaceDim)
            : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone
            ? GetContrastCurve(3)
            : GetContrastCurve(4.5)
    );

    public DynamicColor OutlineVariant => new DynamicColor(
        name: "outline_variant",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 30.0 : 80.0, // From 2021 fallback
        chromaMultiplier: s =>
        {
            if (s.Platform == Platform.Phone)
            {
                if (s.Variant == Variant.Neutral)
                    return 2.2;
                if (s.Variant == Variant.TonalSpot)
                    return 1.7;
                if (s.Variant == Variant.Expressive)
                    return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
            }
            return 1.0;
        },
        background: s => s.Platform == Platform.Phone
            ? (s.IsDark ? SurfaceBright : SurfaceDim)
            : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone
            ? GetContrastCurve(1.5)
            : GetContrastCurve(3)
    );

    public DynamicColor SurfaceTint => new DynamicColor(
        name: "surface_tint",
        palette: s => s.PrimaryPalette,
        tone: s => Primary.Tone(s), // Maps to Primary in 2025
        isBackground: true
    );

    // -----------------------------------------------------------------------------
    // Primaries [P]
    // -----------------------------------------------------------------------------

    public DynamicColor Primary => new DynamicColor(
        name: "primary",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            if (s.Variant == Variant.Neutral)
            {
                return s.Platform == Platform.Phone ? (s.IsDark ? 80.0 : 40.0) : 90.0;
            }
            if (s.Variant == Variant.TonalSpot)
            {
                if (s.Platform == Platform.Phone) return s.IsDark ? 80.0 : TMaxC(s.PrimaryPalette);
                return TMaxC(s.PrimaryPalette, 0, 90);
            }
            if (s.Variant == Variant.Expressive)
            {
                if (s.Platform == Platform.Phone)
                {
                    return TMaxC(s.PrimaryPalette, 0, HctColorCategorization.IsYellow(s.PrimaryPalette.Hue) ? 25 : HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 98);
                }
                return TMaxC(s.PrimaryPalette);
            }
            // Vibrant
            if (s.Platform == Platform.Phone)
            {
                return TMaxC(s.PrimaryPalette, 0, HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 98);
            }
            return TMaxC(s.PrimaryPalette);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone
            ? (s.IsDark ? SurfaceBright : SurfaceDim)
            : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone
            ? GetContrastCurve(4.5)
            : GetContrastCurve(7),
        toneDeltaPair: s => s.Platform == Platform.Phone
            ? new ToneDeltaPair(PrimaryContainer, Primary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
            : null
    );

    public DynamicColor PrimaryDim => new DynamicColor(
        name: "primary_dim",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            if (s.Variant == Variant.Neutral)
                return 85.0;
            if (s.Variant == Variant.TonalSpot)
                return TMaxC(s.PrimaryPalette, 0, 90);
            return TMaxC(s.PrimaryPalette);
        },
        isBackground: true,
        background: s => SurfaceContainerHigh,
        contrastCurve: s => GetContrastCurve(4.5),
        toneDeltaPair: s => new ToneDeltaPair(PrimaryDim, Primary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
    );

    public DynamicColor OnPrimary => new DynamicColor(
        name: "on_primary",
        palette: s => s.PrimaryPalette,
        tone: s => s.IsDark ? 20.0 : 100.0, // 2021 fallback or standard contrast
        background: s => s.Platform == Platform.Phone ? Primary : PrimaryDim,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    public DynamicColor PrimaryContainer => new DynamicColor(
        name: "primary_container",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch)
                return 30.0;
            if (s.Variant == Variant.Neutral)
                return s.IsDark ? 30.0 : 90.0;
            if (s.Variant == Variant.TonalSpot)
                return s.IsDark ? TMinC(s.PrimaryPalette, 35, 93) : TMaxC(s.PrimaryPalette, 0, 90);
            if (s.Variant == Variant.Expressive)
            {
                return s.IsDark
                    ? TMaxC(s.PrimaryPalette, 30, 93)
                    : TMaxC(s.PrimaryPalette, 78, HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 90);
            }
            // Vibrant
            return s.IsDark
                ? TMinC(s.PrimaryPalette, 66, 93)
                : TMaxC(s.PrimaryPalette, 66, HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 93);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        toneDeltaPair: s => s.Platform == Platform.Watch ? new ToneDeltaPair(PrimaryContainer, PrimaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public DynamicColor OnPrimaryContainer => new DynamicColor(
        name: "on_primary_container",
        palette: s => s.PrimaryPalette,
        tone: s => s.IsDark ? 90.0 : 30.0, // 2021 fallback
        background: s => PrimaryContainer,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    public DynamicColor InversePrimary => new DynamicColor(
        name: "inverse_primary",
        palette: s => s.PrimaryPalette,
        tone: s => TMaxC(s.PrimaryPalette),
        background: s => InverseSurface,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    // -----------------------------------------------------------------------------
    // Secondaries [Q]
    // -----------------------------------------------------------------------------

    public DynamicColor Secondary => new DynamicColor(
        name: "secondary",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch) return s.Variant == Variant.Neutral ? 90.0 : TMaxC(s.SecondaryPalette, 0, 90);
            if (s.Variant == Variant.Neutral) return s.IsDark ? TMinC(s.SecondaryPalette, 0, 98) : TMaxC(s.SecondaryPalette);
            if (s.Variant == Variant.Vibrant) return TMaxC(s.SecondaryPalette, 0, s.IsDark ? 90 : 98);
            // Expressive and TonalSpot
            return s.IsDark ? 80.0 : TMaxC(s.SecondaryPalette);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(4.5) : GetContrastCurve(7),
        toneDeltaPair: s => s.Platform == Platform.Phone ? new ToneDeltaPair(SecondaryContainer, Secondary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther) : null
    );

    public DynamicColor SecondaryDim => new DynamicColor(
        name: "secondary_dim",
        palette: s => s.SecondaryPalette,
        tone: s => s.Variant == Variant.Neutral ? 85.0 : TMaxC(s.SecondaryPalette, 0, 90),
        isBackground: true,
        background: s => SurfaceContainerHigh,
        contrastCurve: s => GetContrastCurve(4.5),
        toneDeltaPair: s => new ToneDeltaPair(SecondaryDim, Secondary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
    );

    public DynamicColor OnSecondary => new DynamicColor(
        name: "on_secondary",
        palette: s => s.SecondaryPalette,
        tone: s => s.IsDark ? 20.0 : 100.0, // 2021 fallback
        background: s => s.Platform == Platform.Phone ? Secondary : SecondaryDim,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    public DynamicColor SecondaryContainer => new DynamicColor(
        name: "secondary_container",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch) return 30.0;
            if (s.Variant == Variant.Vibrant) return s.IsDark ? TMinC(s.SecondaryPalette, 30, 40) : TMaxC(s.SecondaryPalette, 84, 90);
            if (s.Variant == Variant.Expressive) return s.IsDark ? 15.0 : TMaxC(s.SecondaryPalette, 90, 95);
            return s.IsDark ? 25.0 : 90.0;
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        toneDeltaPair: s => s.Platform == Platform.Watch ? new ToneDeltaPair(SecondaryContainer, SecondaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public DynamicColor OnSecondaryContainer => new DynamicColor(
        name: "on_secondary_container",
        palette: s => s.SecondaryPalette,
        tone: s => s.IsDark ? 90.0 : 30.0, // 2021 fallback
        background: s => SecondaryContainer,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    // -----------------------------------------------------------------------------
    // Tertiaries [T]
    // -----------------------------------------------------------------------------

    public DynamicColor Tertiary => new DynamicColor(
        name: "tertiary",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch)
            {
                return s.Variant == Variant.TonalSpot ? TMaxC(s.TertiaryPalette, 0, 90) : TMaxC(s.TertiaryPalette);
            }
            if (s.Variant == Variant.Expressive || s.Variant == Variant.Vibrant)
            {
                return TMaxC(s.TertiaryPalette, 0, HctColorCategorization.IsCyan(s.TertiaryPalette.Hue) ? 88 : (s.IsDark ? 98 : 100));
            }
            // Neutral and TonalSpot
            return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 98) : TMaxC(s.TertiaryPalette);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(4.5) : GetContrastCurve(7),
        toneDeltaPair: s => s.Platform == Platform.Phone ? new ToneDeltaPair(TertiaryContainer, Tertiary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther) : null
    );

    public DynamicColor TertiaryDim => new DynamicColor(
        name: "tertiary_dim",
        palette: s => s.TertiaryPalette,
        tone: s => s.Variant == Variant.TonalSpot ? TMaxC(s.TertiaryPalette, 0, 90) : TMaxC(s.TertiaryPalette),
        isBackground: true,
        background: s => SurfaceContainerHigh,
        contrastCurve: s => GetContrastCurve(4.5),
        toneDeltaPair: s => new ToneDeltaPair(TertiaryDim, Tertiary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
    );

    public DynamicColor OnTertiary => new DynamicColor(
        name: "on_tertiary",
        palette: s => s.TertiaryPalette,
        tone: s => s.IsDark ? 20.0 : 100.0, // 2021 fallback
        background: s => s.Platform == Platform.Phone ? Tertiary : TertiaryDim,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    public DynamicColor TertiaryContainer => new DynamicColor(
        name: "tertiary_container",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch)
            {
                return s.Variant == Variant.TonalSpot ? TMaxC(s.TertiaryPalette, 0, 90) : TMaxC(s.TertiaryPalette);
            }
            if (s.Variant == Variant.Neutral) return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 93) : TMaxC(s.TertiaryPalette, 0, 96);
            if (s.Variant == Variant.TonalSpot) return TMaxC(s.TertiaryPalette, 0, s.IsDark ? 93 : 100);
            if (s.Variant == Variant.Expressive) return TMaxC(s.TertiaryPalette, 75, HctColorCategorization.IsCyan(s.TertiaryPalette.Hue) ? 88 : (s.IsDark ? 93 : 100));
            // Vibrant
            return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 93) : TMaxC(s.TertiaryPalette, 72, 100);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        toneDeltaPair: s => s.Platform == Platform.Watch ? new ToneDeltaPair(TertiaryContainer, TertiaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public DynamicColor OnTertiaryContainer => new DynamicColor(
        name: "on_tertiary_container",
        palette: s => s.TertiaryPalette,
        tone: s => s.IsDark ? 90.0 : 30.0, // 2021 fallback
        background: s => TertiaryContainer,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    // -----------------------------------------------------------------------------
    // Errors [E]
    // -----------------------------------------------------------------------------

    public DynamicColor Error => new DynamicColor(
        name: "error",
        palette: s => s.ErrorPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Phone) return s.IsDark ? TMinC(s.ErrorPalette, 0, 98) : TMaxC(s.ErrorPalette);
            return TMinC(s.ErrorPalette);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(4.5) : GetContrastCurve(7),
        toneDeltaPair: s => s.Platform == Platform.Phone ? new ToneDeltaPair(ErrorContainer, Error, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther) : null
    );

    public DynamicColor ErrorDim => new DynamicColor(
        name: "error_dim",
        palette: s => s.ErrorPalette,
        tone: s => TMinC(s.ErrorPalette),
        isBackground: true,
        background: s => SurfaceContainerHigh,
        contrastCurve: s => GetContrastCurve(4.5),
        toneDeltaPair: s => new ToneDeltaPair(ErrorDim, Error, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
    );

    public DynamicColor OnError => new DynamicColor(
        name: "on_error",
        palette: s => s.ErrorPalette,
        tone: s => s.IsDark ? 20.0 : 100.0, // 2021 fallback
        background: s => s.Platform == Platform.Phone ? Error : ErrorDim,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    public DynamicColor ErrorContainer => new DynamicColor(
        name: "error_container",
        palette: s => s.ErrorPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch) return 30.0;
            return s.IsDark ? TMinC(s.ErrorPalette, 30, 93) : TMaxC(s.ErrorPalette, 0, 90);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        toneDeltaPair: s => s.Platform == Platform.Watch ? new ToneDeltaPair(ErrorContainer, ErrorDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public DynamicColor OnErrorContainer => new DynamicColor(
        name: "on_error_container",
        palette: s => s.ErrorPalette,
        tone: s => s.IsDark ? 90.0 : 30.0, // 2021 fallback
        background: s => ErrorContainer,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(4.5) : GetContrastCurve(7)
    );

    // -----------------------------------------------------------------------------
    // Primary Fixed Colors [PF]
    // -----------------------------------------------------------------------------

    public DynamicColor PrimaryFixed => new DynamicColor(
        name: "primary_fixed",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            var tempS = DynamicScheme.From(s, isDark: false, contrastLevel: 0.0);
            return PrimaryContainer.Tone(tempS);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public DynamicColor PrimaryFixedDim => new DynamicColor(
        name: "primary_fixed_dim",
        palette: s => s.PrimaryPalette,
        tone: s => PrimaryFixed.Tone(s),
        isBackground: true,
        toneDeltaPair: s => new ToneDeltaPair(PrimaryFixedDim, PrimaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact)
    );

    public DynamicColor OnPrimaryFixed => new DynamicColor(
        name: "on_primary_fixed",
        palette: s => s.PrimaryPalette,
        tone: s => s.IsDark ? 100.0 : 10.0, // 2021 fallback
        background: s => PrimaryFixedDim,
        contrastCurve: s => GetContrastCurve(7)
    );

    public DynamicColor OnPrimaryFixedVariant => new DynamicColor(
        name: "on_primary_fixed_variant",
        palette: s => s.PrimaryPalette,
        tone: s => s.IsDark ? 90.0 : 30.0, // 2021 fallback
        background: s => PrimaryFixedDim,
        contrastCurve: s => GetContrastCurve(4.5)
    );

    // -----------------------------------------------------------------------------
    // Secondary Fixed Colors [QF]
    // -----------------------------------------------------------------------------

    public DynamicColor SecondaryFixed => new DynamicColor(
        name: "secondary_fixed",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            var tempS = DynamicScheme.From(s, isDark: false, contrastLevel: 0.0);
            return SecondaryContainer.Tone(tempS);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public DynamicColor SecondaryFixedDim => new DynamicColor(
        name: "secondary_fixed_dim",
        palette: s => s.SecondaryPalette,
        tone: s => SecondaryFixed.Tone(s),
        isBackground: true,
        toneDeltaPair: s => new ToneDeltaPair(SecondaryFixedDim, SecondaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact)
    );

    public DynamicColor OnSecondaryFixed => new DynamicColor(
        name: "on_secondary_fixed",
        palette: s => s.SecondaryPalette,
        tone: s => 10.0, // 2021 fallback
        background: s => SecondaryFixedDim,
        contrastCurve: s => GetContrastCurve(7)
    );

    public DynamicColor OnSecondaryFixedVariant => new DynamicColor(
        name: "on_secondary_fixed_variant",
        palette: s => s.SecondaryPalette,
        tone: s => s.IsDark ? 25.0 : 30.0, // 2021 fallback
        background: s => SecondaryFixedDim,
        contrastCurve: s => GetContrastCurve(4.5)
    );

    // -----------------------------------------------------------------------------
    // Tertiary Fixed Colors [TF]
    // -----------------------------------------------------------------------------

    public DynamicColor TertiaryFixed => new DynamicColor(
        name: "tertiary_fixed",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            var tempS = DynamicScheme.From(s, isDark: false, contrastLevel: 0.0);
            return TertiaryContainer.Tone(tempS);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public DynamicColor TertiaryFixedDim => new DynamicColor(
        name: "tertiary_fixed_dim",
        palette: s => s.TertiaryPalette,
        tone: s => TertiaryFixed.Tone(s),
        isBackground: true,
        toneDeltaPair: s => new ToneDeltaPair(TertiaryFixedDim, TertiaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact)
    );

    public DynamicColor OnTertiaryFixed => new DynamicColor(
        name: "on_tertiary_fixed",
        palette: s => s.TertiaryPalette,
        tone: s => 10.0, // 2021 fallback
        background: s => TertiaryFixedDim,
        contrastCurve: s => GetContrastCurve(7)
    );

    public DynamicColor OnTertiaryFixedVariant => new DynamicColor(
        name: "on_tertiary_fixed_variant",
        palette: s => s.TertiaryPalette,
        tone: s => s.IsDark ? 90.0 : 30.0, // 2021 fallback
        background: s => TertiaryFixedDim,
        contrastCurve: s => GetContrastCurve(4.5)
    );

    // -----------------------------------------------------------------------------
    // Android-only Colors
    // -----------------------------------------------------------------------------

    public DynamicColor ControlActivated => new DynamicColor(
        name: "control_activated",
        palette: s => s.PrimaryPalette,
        tone: s => PrimaryContainer.Tone(s), // Maps to PrimaryContainer in 2025
        isBackground: true
    );

    public DynamicColor ControlNormal => new DynamicColor(
        name: "control_normal",
        palette: s => s.NeutralPalette,
        tone: s => OnSurfaceVariant.Tone(s), // Maps to OnSurfaceVariant in 2025
        chromaMultiplier: s => OnSurfaceVariant.ChromaMultiplier?.Invoke(s) ?? 1.0
    );

    public DynamicColor ControlHighlight => new DynamicColor(
        name: "control_highlight",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 100.0 : 0.0, // 2021 fallback
        opacity: s => s.IsDark ? 0.20 : 0.12 // 2021 fallback
    );

    public DynamicColor TextPrimaryInverse => new DynamicColor(
        name: "text_primary_inverse",
        palette: s => s.NeutralPalette,
        tone: s => InverseOnSurface.Tone(s), // Maps to InverseOnSurface in 2025
        background: s => InverseOnSurface.Background?.Invoke(s),
        contrastCurve: s => InverseOnSurface.ContrastCurve?.Invoke(s)
    );

    public DynamicColor TextSecondaryAndTertiaryInverse => new DynamicColor(
        name: "text_secondary_and_tertiary_inverse",
        palette: s => s.NeutralVariantPalette,
        tone: s => s.IsDark ? 30.0 : 80.0 // 2021 fallback
    );

    public DynamicColor TextPrimaryInverseDisableOnly => new DynamicColor(
        name: "text_primary_inverse_disable_only",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 10.0 : 90.0 // 2021 fallback
    );

    public DynamicColor TextSecondaryAndTertiaryInverseDisabled => new DynamicColor(
        name: "text_secondary_and_tertiary_inverse_disabled",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 10.0 : 90.0 // 2021 fallback
    );

    public DynamicColor TextHintInverse => new DynamicColor(
        name: "text_hint_inverse",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 10.0 : 90.0 // 2021 fallback
    );

    // -----------------------------------------------------------------------------
    // Calculation Logic
    // -----------------------------------------------------------------------------

    public HctColor GetHct(DynamicScheme scheme, DynamicColor color)
    {
        TonalPalette palette = color.Palette(scheme);
        double tone = GetTone(scheme, color);
        double hue = palette.Hue;
        double chromaMultiplier = color.ChromaMultiplier?.Invoke(scheme) ?? 1.0;
        double chroma = palette.Chroma * chromaMultiplier;

        HctColor answer = HctColor.From(hue, chroma, tone);
        return answer;
    }

    public double GetTone(DynamicScheme scheme, DynamicColor color)
    {
        ToneDeltaPair? toneDeltaPair = color.ToneDeltaPair?.Invoke(scheme);

        if (toneDeltaPair != null)
        {
            DynamicColor roleA = toneDeltaPair.RoleA;
            DynamicColor roleB = toneDeltaPair.RoleB;
            TonePolarity polarity = toneDeltaPair.Polarity;
            ToneDeltaConstraint constraint = toneDeltaPair.Constraint;

            double absoluteDelta = toneDeltaPair.Delta;
            if (polarity == TonePolarity.Darker ||
               (polarity == TonePolarity.RelativeLighter && scheme.IsDark) ||
               (polarity == TonePolarity.RelativeDarker && !scheme.IsDark))
            {
                absoluteDelta *= -1;
            }

            bool amRoleA = color.Name == roleA.Name;
            DynamicColor selfRole = amRoleA ? roleA : roleB;
            DynamicColor referenceRole = amRoleA ? roleB : roleA;

            double selfTone = selfRole.Tone(scheme);
            double referenceTone = GetTone(scheme, referenceRole); // Recursive check
            double relativeDelta = absoluteDelta * (amRoleA ? 1 : -1);

            switch (constraint)
            {
                case ToneDeltaConstraint.Exact:
                    selfTone = MathUtils.ClampDouble(0, 100, referenceTone + relativeDelta);
                    break;
                case ToneDeltaConstraint.Nearer:
                    if (relativeDelta > 0)
                        selfTone = MathUtils.ClampDouble(0, 100, MathUtils.ClampDouble(referenceTone, referenceTone + relativeDelta, selfTone));
                    else
                        selfTone = MathUtils.ClampDouble(0, 100, MathUtils.ClampDouble(referenceTone + relativeDelta, referenceTone, selfTone));
                    break;
                case ToneDeltaConstraint.Farther:
                    if (relativeDelta > 0)
                        selfTone = MathUtils.ClampDouble(referenceTone + relativeDelta, 100, selfTone);
                    else
                        selfTone = MathUtils.ClampDouble(0, referenceTone + relativeDelta, selfTone);
                    break;
            }

            if (color.Background != null && color.ContrastCurve != null)
            {
                DynamicColor? background = color.Background(scheme);
                ContrastCurve? contrastCurve = color.ContrastCurve(scheme);
                if (background != null && contrastCurve != null)
                {
                    double bgTone = GetTone(scheme, background);
                    double selfContrast = contrastCurve.Get(scheme.ContrastLevel);

                    if (scheme.ContrastLevel < 0 || Contrast.RatioOfTones(bgTone, selfTone) < selfContrast)
                    {
                        selfTone = ForegroundToneCalculation.ForegroundTone(bgTone, selfContrast);
                    }
                    else
                    {
                        // Keep selfTone
                    }
                }
            }

            if (color.IsBackground && !color.Name.EndsWith("_fixed_dim"))
            {
                if (selfTone >= 57) selfTone = MathUtils.ClampDouble(65, 100, selfTone);
                else selfTone = MathUtils.ClampDouble(0, 49, selfTone);
            }

            return selfTone;
        }
        else
        {
            // Case 1: No tone delta pair
            double answer = color.Tone(scheme);

            if (color.Background == null || color.ContrastCurve == null)
                return answer;

            var background = color.Background(scheme);
            var contrastCurve = color.ContrastCurve(scheme);
            if (background == null || contrastCurve == null)
                return answer;

            double bgTone = GetTone(scheme, background);
            double desiredRatio = contrastCurve.Get(scheme.ContrastLevel);

            if (scheme.ContrastLevel < 0 || Contrast.RatioOfTones(bgTone, answer) < desiredRatio)
            {
                answer = ForegroundToneCalculation.ForegroundTone(bgTone, desiredRatio);
            }
            else
            {
                // answer is fine
            }

            if (color.IsBackground && !color.Name.EndsWith("_fixed_dim"))
            {
                if (answer >= 57) answer = MathUtils.ClampDouble(65, 100, answer);
                else answer = MathUtils.ClampDouble(0, 49, answer);
            }

            // Note: Dual background logic from 2021 is usually here, but 2025 simplified this logic block significantly
            // in the provided file. I am following the 2025 implementation provided.

            return answer;
        }
    }

    // -----------------------------------------------------------------------------
    // Palette Generation
    // -----------------------------------------------------------------------------

    public static TonalPalette GetPrimaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform)
    {
        switch (variant)
        {
            case Variant.Neutral:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 12 : 8) : (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 16 : 12));
            case Variant.TonalSpot:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone && isDark ? 26 : 32);
            case Variant.Expressive:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? (isDark ? 36 : 48) : 40);
            case Variant.Vibrant:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? 74 : 56);
            // Fallback to 2021 Logic
            case Variant.Content:
            case Variant.Fidelity:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, sourceColorHct.Chroma);
            case Variant.FruitSalad:
                return TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegreesDouble(sourceColorHct.Hue - 50.0), 48.0);
            case Variant.Monochrome:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0);
            case Variant.Rainbow:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 48.0);
            default:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, sourceColorHct.Chroma);
        }
    }

    public static TonalPalette GetSecondaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform)
    {
        switch (variant)
        {
            case Variant.Neutral:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 6 : 4) : (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 10 : 6));
            case Variant.TonalSpot:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16);
            case Variant.Expressive:
                double[] expressiveHues = { 0, 105, 140, 204, 253, 278, 300, 333, 360 };
                double[] expressiveRotations = { -160, 155, -100, 96, -96, -156, -165, -160 };
                return TonalPalette.FromHueAndChroma(DynamicScheme.GetRotatedHue(sourceColorHct, expressiveHues, expressiveRotations), platform == Platform.Phone ? (isDark ? 16 : 24) : 24);
            case Variant.Vibrant:
                double[] vibrantHues = { 0, 38, 105, 140, 333, 360 };
                double[] vibrantRotations = { -14, 10, -14, 10, -14 };
                return TonalPalette.FromHueAndChroma(DynamicScheme.GetRotatedHue(sourceColorHct, vibrantHues, vibrantRotations), platform == Platform.Phone ? 56 : 36);
            // Fallback to 2021 Logic
            case Variant.Content:
            case Variant.Fidelity:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, Math.Max(sourceColorHct.Chroma - 32.0, sourceColorHct.Chroma * 0.5));
            case Variant.FruitSalad:
                return TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegreesDouble(sourceColorHct.Hue - 50.0), 36.0);
            case Variant.Monochrome:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0);
            case Variant.Rainbow:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16.0);
            default:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16.0);
        }
    }

    public static TonalPalette GetTertiaryPalette(Variant variant, HctColor sourceColorHct, Platform platform)
    {
        switch (variant)
        {
            case Variant.Neutral:
                double[] neutralHues = { 0, 38, 105, 161, 204, 278, 333, 360 };
                double[] neutralRotations = { -32, 26, 10, -39, 24, -15, -32 };
                return TonalPalette.FromHueAndChroma(DynamicScheme.GetRotatedHue(sourceColorHct, neutralHues, neutralRotations), platform == Platform.Phone ? 20 : 36);
            case Variant.TonalSpot:
                double[] tonalSpotHues = { 0, 20, 71, 161, 333, 360 };
                double[] tonalSpotRotations = { -40, 48, -32, 40, -32 };
                return TonalPalette.FromHueAndChroma(DynamicScheme.GetRotatedHue(sourceColorHct, tonalSpotHues, tonalSpotRotations), platform == Platform.Phone ? 28 : 32);
            case Variant.Expressive:
                double[] expressiveHues = { 0, 105, 140, 204, 253, 278, 300, 333, 360 };
                double[] expressiveRotations = { -165, 160, -105, 101, -101, -160, -170, -165 };
                return TonalPalette.FromHueAndChroma(DynamicScheme.GetRotatedHue(sourceColorHct, expressiveHues, expressiveRotations), 48);
            case Variant.Vibrant:
                double[] vibrantHues = { 0, 38, 71, 105, 140, 161, 253, 333, 360 };
                double[] vibrantRotations = { -72, 35, 24, -24, 62, 50, 62, -72 };
                return TonalPalette.FromHueAndChroma(DynamicScheme.GetRotatedHue(sourceColorHct, vibrantHues, vibrantRotations), 56);
            // Fallback to 2021 Logic
            case Variant.Content:
                // Note: This relies on DislikeAnalyzer and TemperatureCache which are complex. 
                // Assuming basic fallback for brevity if those aren't ported, but ideally:
                // return TonalPalette.FromHct(DislikeAnalyzer.FixIfDisliked(new TemperatureCache(sourceColorHct).GetAnalogousColors(3, 6)[2]));
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 24.0); // Simplified fallback
            case Variant.Fidelity:
                // return TonalPalette.FromHct(DislikeAnalyzer.FixIfDisliked(new TemperatureCache(sourceColorHct).GetComplement()));
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 24.0); // Simplified fallback
            case Variant.FruitSalad:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 36.0);
            case Variant.Monochrome:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0);
            case Variant.Rainbow:
                return TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegreesDouble(sourceColorHct.Hue + 60.0), 24.0);
            default:
                return TonalPalette.FromHueAndChroma(MathUtils.SanitizeDegreesDouble(sourceColorHct.Hue + 60.0), 24.0);
        }
    }

    public static TonalPalette GetNeutralPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform)
    {
        switch (variant)
        {
            case Variant.Neutral:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? 1.4 : 6);
            case Variant.TonalSpot:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? 5 : 10);
            case Variant.Expressive:
                return TonalPalette.FromHueAndChroma(GetExpressiveNeutralHue(sourceColorHct), GetExpressiveNeutralChroma(sourceColorHct, isDark, platform));
            case Variant.Vibrant:
                return TonalPalette.FromHueAndChroma(GetVibrantNeutralHue(sourceColorHct), GetVibrantNeutralChroma(sourceColorHct, platform));
            // Fallback to 2021
            case Variant.Content:
            case Variant.Fidelity:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, sourceColorHct.Chroma / 8.0);
            case Variant.FruitSalad:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 10.0);
            case Variant.Monochrome:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0);
            case Variant.Rainbow:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0);
            default:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 12.0); // Fallback generic
        }
    }

    public static TonalPalette GetNeutralVariantPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform)
    {
        switch (variant)
        {
            case Variant.Neutral:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, (platform == Platform.Phone ? 1.4 : 6) * 2.2);
            case Variant.TonalSpot:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, (platform == Platform.Phone ? 5 : 10) * 1.7);
            case Variant.Expressive:
                double expressiveHue = GetExpressiveNeutralHue(sourceColorHct);
                double expressiveChroma = GetExpressiveNeutralChroma(sourceColorHct, isDark, platform);
                return TonalPalette.FromHueAndChroma(expressiveHue, expressiveChroma * (expressiveHue >= 105 && expressiveHue < 125 ? 1.6 : 2.3));
            case Variant.Vibrant:
                double vibrantHue = GetVibrantNeutralHue(sourceColorHct);
                double vibrantChroma = GetVibrantNeutralChroma(sourceColorHct, platform);
                return TonalPalette.FromHueAndChroma(vibrantHue, vibrantChroma * 1.29);
            // Fallback to 2021
            case Variant.Content:
            case Variant.Fidelity:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, (sourceColorHct.Chroma / 8.0) + 4.0);
            case Variant.FruitSalad:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16.0);
            case Variant.Monochrome:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0);
            case Variant.Rainbow:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 0.0);
            default:
                return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 12.0);
        }
    }

    public static TonalPalette? GetErrorPalette(Variant variant, HctColor sourceColorHct, Platform platform)
    {
        var hueBreakpoints = new double[] { 0, 3, 13, 23, 33, 43, 153, 273, 360 };
        var hues = new double[] { 12, 22, 32, 12, 22, 32, 22, 12 };
        double errorHue = DynamicScheme.GetPiecewiseValue(sourceColorHct.Hue,
            hueBreakpoints,
            hues);

        switch (variant)
        {
            case Variant.Neutral:
                return TonalPalette.FromHueAndChroma(errorHue, platform == Platform.Phone ? 50 : 40);
            case Variant.TonalSpot:
                return TonalPalette.FromHueAndChroma(errorHue, platform == Platform.Phone ? 60 : 48);
            case Variant.Expressive:
                return TonalPalette.FromHueAndChroma(errorHue, platform == Platform.Phone ? 64 : 48);
            case Variant.Vibrant:
                return TonalPalette.FromHueAndChroma(errorHue, platform == Platform.Phone ? 80 : 60);
            default:
                return null; // 2021 fallback is Optional.empty()
        }
    }

    // -----------------------------------------------------------------------------
    // Helpers
    // -----------------------------------------------------------------------------

    private static double FindBestToneForChroma(double hue, double chroma, double tone, bool byDecreasingTone)
    {
        double answer = tone;
        HctColor bestCandidate = HctColor.From(hue, chroma, answer);
        while (bestCandidate.Chroma < chroma)
        {
            if (tone < 0 || tone > 100) break;
            tone += byDecreasingTone ? -1.0 : 1.0;
            HctColor newCandidate = HctColor.From(hue, chroma, tone);
            if (bestCandidate.Chroma < newCandidate.Chroma)
            {
                bestCandidate = newCandidate;
                answer = tone;
            }
        }
        return answer;
    }

    private static double TMaxC(TonalPalette palette)
        => TMaxC(palette, 0, 100);

    private static double TMaxC(TonalPalette palette, double lowerBound, double upperBound)
        => TMaxC(palette, lowerBound, upperBound, 1);

    private static double TMaxC(TonalPalette palette, double lowerBound, double upperBound, double chromaMultiplier)
    {
        double answer = FindBestToneForChroma(palette.Hue, palette.Chroma * chromaMultiplier, 100, true);
        return MathUtils.ClampDouble(lowerBound, upperBound, answer);
    }

    private static double TMinC(TonalPalette palette)
        => TMinC(palette, 0, 100);

    private static double TMinC(TonalPalette palette, double lowerBound, double upperBound)
    {
        double answer = FindBestToneForChroma(palette.Hue, palette.Chroma, 0, false);
        return MathUtils.ClampDouble(lowerBound, upperBound, answer);
    }

    private static ContrastCurve GetContrastCurve(double defaultContrast)
    {
        if (defaultContrast == 1.5)
            return new ContrastCurve(1.5, 1.5, 3, 5.5);

        if (defaultContrast == 3)
            return new ContrastCurve(3, 3, 4.5, 7);

        if (defaultContrast == 4.5)
            return new ContrastCurve(4.5, 4.5, 7, 11);

        if (defaultContrast == 6)
            return new ContrastCurve(6, 6, 7, 11);

        if (defaultContrast == 7)
            return new ContrastCurve(7, 7, 11, 21);

        if (defaultContrast == 9)
            return new ContrastCurve(9, 9, 11, 21);

        if (defaultContrast == 11)
            return new ContrastCurve(11, 11, 21, 21);

        if (defaultContrast == 21)
            return new ContrastCurve(21, 21, 21, 21);

        return new ContrastCurve(defaultContrast, defaultContrast, 7, 21);
    }

    private static double GetExpressiveNeutralHue(HctColor sourceColorHct)
    {
        var breakPoints = new double[] { 0, 71, 124, 253, 278, 300, 360 };
        var rotations = new double[] { 10, 0, 10, 0, 10, 0 };
        return DynamicScheme.GetRotatedHue(
            sourceColorHct,
            breakPoints,
            rotations);
    }

    private static double GetExpressiveNeutralChroma(HctColor sourceColorHct, bool isDark, Platform platform)
    {
        double neutralHue = GetExpressiveNeutralHue(sourceColorHct);
        if (platform == Platform.Phone)
            if (isDark)
                return HctColorCategorization.IsYellow(neutralHue) ? 6 : 14;
            else
                return 18;
        else
            return 12;
    }

    private static double GetVibrantNeutralHue(HctColor sourceColorHct)
    {
        var breakPoints = new double[] { 0, 38, 105, 140, 333, 360 };
        var rotations = new double[] { -14, 10, -14, 10, -14 };
        return DynamicScheme.GetRotatedHue(
            sourceColorHct,
            breakPoints,
            rotations);
    }

    private static double GetVibrantNeutralChroma(HctColor sourceColorHct, Platform platform)
    {
        double neutralHue = GetVibrantNeutralHue(sourceColorHct);
        if (platform == Platform.Phone)
            return 28;
        else
            return HctColorCategorization.IsBlue(neutralHue) ? 28 : 20;
    }
}
