using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.Contrasts;
using MaterialTheming.MaterialDesign.Hct;
using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;

internal class ColorSpec2025 : ColorSpec2021
{
    // ----------------------------------------------------------------
    // Surfaces
    // ----------------------------------------------------------------

    public override DynamicColor Background => CreateBackground().Build();
    public DynamicColorBuilder CreateBackground()
    {
        return DynamicColorBuilder.Create(Surface)
            .WithName("background");
    }

    public override DynamicColor OnBackground => new(
        name: "on_background",
        palette: s => s.NeutralPalette,
        tone: s => s.Platform == Platform.Watch ? 100.0 : base.OnSurface.GetTone(s),
        background: s => Background,
        contrastCurve: s => new ContrastCurve(3.0, 3.0, 4.5, 7.0)
    );

    public override DynamicColor Surface => new(
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

    public override DynamicColor SurfaceDim => new(
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

    public override DynamicColor SurfaceBright => new(
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

    public override DynamicColor SurfaceContainerLowest => new(
        name: "surface_container_lowest",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 0.0 : 100.0,
        isBackground: true
    );

    public override DynamicColor SurfaceContainerLow => new(
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

    public override DynamicColor SurfaceContainer => new(
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

    public override DynamicColor SurfaceContainerHigh => new(
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

    public override DynamicColor SurfaceContainerHighest => new(
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

    public override DynamicColor OnSurface => new(
        name: "on_surface",
        palette: s => s.NeutralPalette,
        tone: s =>
        {
            if (s.Variant == Variant.Vibrant) return TMaxC(s.NeutralPalette, 0, 100, 1.1);
            return ForegroundToneCalculation.GetInitialToneFromBackground(scheme =>
            {
                if (scheme.Platform == Platform.Phone)
                    return scheme.IsDark ? SurfaceBright : SurfaceDim;
                return SurfaceContainerHigh;
            })(s);
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

    public override DynamicColor SurfaceVariant => new(
        name: "surface_variant",
        palette: s => s.NeutralVariantPalette,
        tone: s => SurfaceContainerHighest.GetTone(s), // Mapped to SurfaceContainerHighest
        isBackground: true
    );

    public override DynamicColor OnSurfaceVariant => CreateOnSurfaceVariant().Build();

    public DynamicColorBuilder CreateOnSurfaceVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_surface_variant")
            .WithPalette(s => s.NeutralPalette)
            .WithChromaMultiplier(s =>
            {
                if (s.Platform == Platform.Phone)
                {
                    if (s.Variant == Variant.Neutral) return 2.2;
                    if (s.Variant == Variant.TonalSpot) return 1.7;
                    if (s.Variant == Variant.Expressive) return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
                }
                return 1.0;
            })
            .WithBackground(s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform == Platform.Phone
            ? (s.IsDark ? GetContrastCurve(6) : GetContrastCurve(4.5))
            : GetContrastCurve(7));
    }

    public override DynamicColor InverseSurface => new(
        name: "inverse_surface",
        palette: s => s.NeutralPalette,
        tone: s => s.IsDark ? 98.0 : 4.0,
        isBackground: true
    );

    public override DynamicColor InverseOnSurface => new(
        name: "inverse_on_surface",
        palette: s => s.NeutralPalette,
        tone: s => base.InverseOnSurface.Tone(s),
        background: s => InverseSurface,
        contrastCurve: s => GetContrastCurve(7)
    );

    public override DynamicColor Outline => new(
        name: "outline",
        palette: s => s.NeutralPalette,
        tone: s => base.Outline.Tone(s),
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
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(3) : GetContrastCurve(4.5)
    );

    public override DynamicColor OutlineVariant => new(
        name: "outline_variant",
        palette: s => s.NeutralPalette,
        tone: s => base.OutlineVariant.Tone(s),
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
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(1.5) : GetContrastCurve(3)
    );

    public override DynamicColor SurfaceTint => new(
        name: "surface_tint",
        palette: s => s.PrimaryPalette,
        tone: s => Primary.GetTone(s),
        isBackground: true
    );

    // ----------------------------------------------------------------
    // Primaries
    // ----------------------------------------------------------------

    public override DynamicColor Primary => CreatePrimary().Build();
    public DynamicColorBuilder CreatePrimary()
    {
        Func<DynamicScheme, double> toneFunction = s =>
        {
            if (s.Variant == Variant.Neutral)
            {
                if (s.Platform == Platform.Phone)
                    return s.IsDark ? 80.0 : 40.0;
                return 90.0;
            }
            if (s.Variant == Variant.TonalSpot)
            {
                if (s.Platform == Platform.Phone)
                {
                    if (s.IsDark)
                        return 80.0;
                    return TMaxC(s.PrimaryPalette);
                }
                return TMaxC(s.PrimaryPalette, 0, 90);
            }
            if (s.Variant == Variant.Expressive)
            {
                if (s.Platform == Platform.Phone)
                {
                    return TMaxC(s.PrimaryPalette, 0, HctColorCategorization.IsYellow(s.PrimaryPalette.Hue) ? 25 : HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 98);
                }
                return TMaxC(s.PrimaryPalette); //Watch
            }
            // Vibrant
            if (s.Platform == Platform.Phone)
            {
                return TMaxC(s.PrimaryPalette, 0, HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 98);
            }
            return TMaxC(s.PrimaryPalette);
        };
        return DynamicColorBuilder.Create()
            .WithName("primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(toneFunction)
            .WithIsBackground(true)
            .WithBackground(s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform == Platform.Phone ? GetContrastCurve(4.5) : GetContrastCurve(7))
            .WithToneDeltaPair(s => s.Platform == Platform.Phone
                    ? new ToneDeltaPair(PrimaryContainer, Primary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
                    : null);
    }

    public override DynamicColor PrimaryDim => new(
        name: "primary_dim",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            if (s.Variant == Variant.Neutral) return 85.0;
            if (s.Variant == Variant.TonalSpot) return TMaxC(s.PrimaryPalette, 0, 90);
            return TMaxC(s.PrimaryPalette);
        },
        isBackground: true,
        background: s => SurfaceContainerHigh,
        contrastCurve: s => GetContrastCurve(4.5),
        toneDeltaPair: s => new ToneDeltaPair(PrimaryDim, Primary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
    );

    public override DynamicColor OnPrimary => CreateOnPrimary().Build();
    public DynamicColorBuilder CreateOnPrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(s => s.Platform == Platform.Phone ? Primary : PrimaryDim)
            .WithContrastCurve(s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor PrimaryContainer => new(
        name: "primary_container",
        palette: s => s.PrimaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch) return 30.0;
            if (s.Variant == Variant.Neutral) return s.IsDark ? 30.0 : 90.0;
            if (s.Variant == Variant.TonalSpot) return s.IsDark ? TMinC(s.PrimaryPalette, 35, 93) : TMaxC(s.PrimaryPalette, 0, 90);
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
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null,
        toneDeltaPair: s => s.Platform == Platform.Watch
            ? new ToneDeltaPair(PrimaryContainer, PrimaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
            : null
    );

    public override DynamicColor OnPrimaryContainer => new(
        name: "on_primary_container",
        palette: s => s.PrimaryPalette,
        tone: s => base.OnPrimaryContainer.Tone(s),
        background: s => PrimaryContainer,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    public override DynamicColor InversePrimary => new(
        name: "inverse_primary",
        palette: s => s.PrimaryPalette,
        tone: s => TMaxC(s.PrimaryPalette),
        background: s => InverseSurface,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7)
    );

    // ----------------------------------------------------------------
    // Secondaries
    // ----------------------------------------------------------------

    public override DynamicColor Secondary => new(
        name: "secondary",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch) return s.Variant == Variant.Neutral ? 90.0 : TMaxC(s.SecondaryPalette, 0, 90);
            if (s.Variant == Variant.Neutral) return s.IsDark ? TMinC(s.SecondaryPalette, 0, 98) : TMaxC(s.SecondaryPalette);
            if (s.Variant == Variant.Vibrant) return TMaxC(s.SecondaryPalette, 0, s.IsDark ? 90 : 98);
            return s.IsDark ? 80.0 : TMaxC(s.SecondaryPalette);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(4.5) : GetContrastCurve(7),
        toneDeltaPair: s => s.Platform == Platform.Phone
            ? new ToneDeltaPair(SecondaryContainer, Secondary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
            : null
    );

    public override DynamicColor SecondaryDim => new(
        name: "secondary_dim",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            if (s.Variant == Variant.Neutral) return 85.0;
            return TMaxC(s.SecondaryPalette, 0, 90);
        },
        isBackground: true,
        background: s => SurfaceContainerHigh,
        contrastCurve: s => GetContrastCurve(4.5),
        toneDeltaPair: s => new ToneDeltaPair(SecondaryDim, Secondary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
    );

    public override DynamicColor OnSecondary => CreateOnSecondary().Build();

    public DynamicColorBuilder CreateOnSecondary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(s => s.Platform == Platform.Phone ? Secondary : SecondaryDim)
            .WithContrastCurve(s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor SecondaryContainer => new(
        name: "secondary_container",
        palette: s => s.SecondaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch) return 30.0;
            if (s.Variant == Variant.Vibrant)
                return s.IsDark ? TMinC(s.SecondaryPalette, 30, 40) : TMaxC(s.SecondaryPalette, 84, 90);
            if (s.Variant == Variant.Expressive)
                return s.IsDark ? 15.0 : TMaxC(s.SecondaryPalette, 90, 95);
            return s.IsDark ? 25.0 : 90.0;
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null,
        toneDeltaPair: s => s.Platform == Platform.Watch
            ? new ToneDeltaPair(SecondaryContainer, SecondaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
            : null
    );

    public override DynamicColor OnSecondaryContainer => CreateOnSecondaryContainer().Build();
    public DynamicColorBuilder CreateOnSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => SecondaryContainer)
            .WithContrastCurve(s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    // ----------------------------------------------------------------
    // Tertiaries
    // ----------------------------------------------------------------

    public override DynamicColor Tertiary => new(
        name: "tertiary",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch)
                return s.Variant == Variant.TonalSpot ? TMaxC(s.TertiaryPalette, 0, 90) : TMaxC(s.TertiaryPalette);

            if (s.Variant == Variant.Expressive || s.Variant == Variant.Vibrant)
            {
                return TMaxC(s.TertiaryPalette, 0, HctColorCategorization.IsCyan(s.TertiaryPalette.Hue) ? 88 : (s.IsDark ? 98 : 100));
            }
            return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 98) : TMaxC(s.TertiaryPalette);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh,
        contrastCurve: s => s.Platform == Platform.Phone ? GetContrastCurve(4.5) : GetContrastCurve(7),
        toneDeltaPair: s => s.Platform == Platform.Phone
            ? new ToneDeltaPair(TertiaryContainer, Tertiary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
            : null
    );

    public override DynamicColor TertiaryDim => new(
        name: "tertiary_dim",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (s.Variant == Variant.TonalSpot) return TMaxC(s.TertiaryPalette, 0, 90);
            return TMaxC(s.TertiaryPalette);
        },
        isBackground: true,
        background: s => SurfaceContainerHigh,
        contrastCurve: s => GetContrastCurve(4.5),
        toneDeltaPair: s => new ToneDeltaPair(TertiaryDim, Tertiary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
    );

    public override DynamicColor OnTertiary => CreateOnTertiary().Build();

    public DynamicColorBuilder CreateOnTertiary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(s => s.Platform == Platform.Phone ? Tertiary : TertiaryDim)
            .WithContrastCurve(s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor TertiaryContainer => new(
        name: "tertiary_container",
        palette: s => s.TertiaryPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch)
            {
                return s.Variant == Variant.TonalSpot ? TMaxC(s.TertiaryPalette, 0, 90) : TMaxC(s.TertiaryPalette);
            }

            if (s.Variant == Variant.Neutral)
            {
                return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 93) : TMaxC(s.TertiaryPalette, 0, 96);
            }
            if (s.Variant == Variant.TonalSpot)
            {
                return TMaxC(s.TertiaryPalette, 0, s.IsDark ? 93 : 100);
            }
            if (s.Variant == Variant.Expressive)
            {
                return TMaxC(s.TertiaryPalette, 75, HctColorCategorization.IsCyan(s.TertiaryPalette.Hue) ? 88 : (s.IsDark ? 93 : 100));
            }
            // Vibrant
            return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 93) : TMaxC(s.TertiaryPalette, 72, 100);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null,
        toneDeltaPair: s => s.Platform == Platform.Watch
            ? new ToneDeltaPair(TertiaryContainer, TertiaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
            : null
    );

    public override DynamicColor OnTertiaryContainer => CreateOnTertiaryContainer().Build();
    public DynamicColorBuilder CreateOnTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => TertiaryContainer)
            .WithContrastCurve(s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    // ----------------------------------------------------------------
    // Errors
    // ----------------------------------------------------------------

    public override DynamicColor Error => new(
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
        toneDeltaPair: s => s.Platform == Platform.Phone
            ? new ToneDeltaPair(ErrorContainer, Error, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
            : null
    );

    public override DynamicColor ErrorDim => new(
        name: "error_dim",
        palette: s => s.ErrorPalette,
        tone: s => TMinC(s.ErrorPalette),
        isBackground: true,
        background: s => SurfaceContainerHigh,
        contrastCurve: s => GetContrastCurve(4.5),
        toneDeltaPair: s => new ToneDeltaPair(ErrorDim, Error, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
    );

    public override DynamicColor OnError => CreateOnError().Build();
    public DynamicColorBuilder CreateOnError()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error")
            .WithPalette(s => s.ErrorPalette)
            .WithBackground(s => s.Platform == Platform.Phone ? Error : ErrorDim)
            .WithContrastCurve(s => s.Platform == Platform.Phone ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor ErrorContainer => new(
        name: "error_container",
        palette: s => s.ErrorPalette,
        tone: s =>
        {
            if (s.Platform == Platform.Watch) return 30.0;
            return s.IsDark ? TMinC(s.ErrorPalette, 30, 93) : TMaxC(s.ErrorPalette, 0, 90);
        },
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null,
        toneDeltaPair: s => s.Platform == Platform.Watch
            ? new ToneDeltaPair(ErrorContainer, ErrorDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
            : null
    );

    public override DynamicColor OnErrorContainer => CreateOnErrorContainer().Build();
    public DynamicColorBuilder CreateOnErrorContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error_container")
            .WithPalette(s => s.ErrorPalette)
            .WithBackground(s => ErrorContainer)
            .WithContrastCurve(s => s.Platform == Platform.Phone ? GetContrastCurve(4.5) : GetContrastCurve(7));
    }

    // ----------------------------------------------------------------
    // Primary Fixed
    // ----------------------------------------------------------------

    public override DynamicColor PrimaryFixed => new(
        name: "primary_fixed",
        palette: s => s.PrimaryPalette,
        tone: s => PrimaryContainer.GetTone(DynamicScheme.From(s, false, 0.0)),
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public override DynamicColor PrimaryFixedDim => new(
        name: "primary_fixed_dim",
        palette: s => s.PrimaryPalette,
        tone: s => PrimaryFixed.GetTone(s),
        isBackground: true,
        toneDeltaPair: s => new ToneDeltaPair(PrimaryFixedDim, PrimaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact)
    );

    public override DynamicColor OnPrimaryFixed => new(
        name: "on_primary_fixed",
        palette: s => s.PrimaryPalette,
        tone: s => base.OnPrimaryFixed.Tone(s),
        background: s => PrimaryFixedDim,
        contrastCurve: s => GetContrastCurve(7)
    );

    public override DynamicColor OnPrimaryFixedVariant => new(
        name: "on_primary_fixed_variant",
        palette: s => s.PrimaryPalette,
        tone: s => base.OnPrimaryFixedVariant.Tone(s),
        background: s => PrimaryFixedDim,
        contrastCurve: s => GetContrastCurve(4.5)
    );

    // ----------------------------------------------------------------
    // Secondary Fixed
    // ----------------------------------------------------------------

    public override DynamicColor SecondaryFixed => new(
        name: "secondary_fixed",
        palette: s => s.SecondaryPalette,
        tone: s => SecondaryContainer.GetTone(DynamicScheme.From(s, false, 0.0)),
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public override DynamicColor SecondaryFixedDim => new(
        name: "secondary_fixed_dim",
        palette: s => s.SecondaryPalette,
        tone: s => SecondaryFixed.GetTone(s),
        isBackground: true,
        toneDeltaPair: s => new ToneDeltaPair(SecondaryFixedDim, SecondaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact)
    );

    public override DynamicColor OnSecondaryFixed => new(
        name: "on_secondary_fixed",
        palette: s => s.SecondaryPalette,
        tone: s => base.OnSecondaryFixed.Tone(s),
        background: s => SecondaryFixedDim,
        contrastCurve: s => GetContrastCurve(7)
    );

    public override DynamicColor OnSecondaryFixedVariant => new(
        name: "on_secondary_fixed_variant",
        palette: s => s.SecondaryPalette,
        tone: s => base.OnSecondaryFixedVariant.Tone(s),
        background: s => SecondaryFixedDim,
        contrastCurve: s => GetContrastCurve(4.5)
    );

    // ----------------------------------------------------------------
    // Tertiary Fixed
    // ----------------------------------------------------------------

    public override DynamicColor TertiaryFixed => new(
        name: "tertiary_fixed",
        palette: s => s.TertiaryPalette,
        tone: s => TertiaryContainer.GetTone(DynamicScheme.From(s, false, 0.0)),
        isBackground: true,
        background: s => s.Platform == Platform.Phone ? (s.IsDark ? SurfaceBright : SurfaceDim) : null,
        contrastCurve: s => s.Platform == Platform.Phone && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
    );

    public override DynamicColor TertiaryFixedDim => new(
        name: "tertiary_fixed_dim",
        palette: s => s.TertiaryPalette,
        tone: s => TertiaryFixed.GetTone(s),
        isBackground: true,
        toneDeltaPair: s => new ToneDeltaPair(TertiaryFixedDim, TertiaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact)
    );

    public override DynamicColor OnTertiaryFixed => new(
        name: "on_tertiary_fixed",
        palette: s => s.TertiaryPalette,
        tone: s => base.OnTertiaryFixed.Tone(s),
        background: s => TertiaryFixedDim,
        contrastCurve: s => GetContrastCurve(7)
    );

    public override DynamicColor OnTertiaryFixedVariant => new(
        name: "on_tertiary_fixed_variant",
        palette: s => s.TertiaryPalette,
        tone: s => base.OnTertiaryFixedVariant.Tone(s),
        background: s => TertiaryFixedDim,
        contrastCurve: s => GetContrastCurve(4.5)
    );

    // ----------------------------------------------------------------
    // Android-only
    // ----------------------------------------------------------------

    public override DynamicColor ControlActivated => new(
        name: "control_activated",
        palette: s => s.PrimaryPalette,
        tone: s => PrimaryContainer.GetTone(s),
        isBackground: true
    );

    public override DynamicColor ControlNormal => new(
        name: "control_normal",
        palette: s => s.NeutralPalette,
        tone: s => OnSurfaceVariant.GetTone(s)
    );

    public override DynamicColor TextPrimaryInverse => new(
        name: "text_primary_inverse",
        palette: s => s.NeutralPalette,
        tone: s => InverseOnSurface.GetTone(s)
    );

    // ----------------------------------------------------------------
    // Calculations & Logic
    // ----------------------------------------------------------------

    public override HctColor GetHct(DynamicScheme scheme, DynamicColor color)
    {
        TonalPalette palette = color.Palette(scheme);
        double tone = GetTone(scheme, color);
        double hue = palette.Hue;
        double chromaMultiplier = color.ChromaMultiplier?.Invoke(scheme) ?? 1.0;
        double chroma = palette.Chroma * chromaMultiplier;

        return HctColor.From(hue, chroma, tone);
    }

    public override double GetTone(DynamicScheme scheme, DynamicColor color)
    {
        // Case 0: Tone Delta Pair exists
        ToneDeltaPair? toneDeltaPair = color.ToneDeltaPair?.Invoke(scheme);
        if (toneDeltaPair != null)
        {
            DynamicColor roleA = toneDeltaPair.RoleA;
            DynamicColor roleB = toneDeltaPair.RoleB;
            TonePolarity polarity = toneDeltaPair.Polarity;
            ToneDeltaConstraint constraint = toneDeltaPair.Constraint;

            bool invertDelta = polarity == TonePolarity.Darker ||
                (polarity == TonePolarity.RelativeLighter && scheme.IsDark) ||
                (polarity == TonePolarity.RelativeDarker && !scheme.IsDark);
            double absoluteDelta = invertDelta ? -toneDeltaPair.Delta : toneDeltaPair.Delta;

            bool amRoleA = color.Name == roleA.Name;
            DynamicColor selfRole = amRoleA ? roleA : roleB;
            DynamicColor referenceRole = amRoleA ? roleB : roleA;

            double selfTone = selfRole.Tone(scheme);
            double referenceTone = referenceRole.GetTone(scheme);
            double relativeDelta = amRoleA ? absoluteDelta : -absoluteDelta;

            switch (constraint)
            {
                case ToneDeltaConstraint.Exact:
                    selfTone = Math.Clamp(referenceTone + relativeDelta, 0, 100);
                    break;
                case ToneDeltaConstraint.Nearer:
                    if (relativeDelta > 0)
                        selfTone = Math.Clamp(Math.Clamp(selfTone, referenceTone, referenceTone + relativeDelta), 0, 100);
                    else
                        selfTone = Math.Clamp(Math.Clamp(selfTone, referenceTone + relativeDelta, referenceTone), 0, 100);
                    break;
                case ToneDeltaConstraint.Farther:
                    if (relativeDelta > 0)
                        selfTone = Math.Clamp(selfTone, referenceTone + relativeDelta, 100);
                    else
                        selfTone = Math.Clamp(selfTone, 0, referenceTone + relativeDelta);
                    break;
            }

            if (color.Background != null && color.ContrastCurve != null)
            {
                DynamicColor? background = color.Background(scheme);
                ContrastCurve? contrastCurve = color.ContrastCurve(scheme);
                if (background != null && contrastCurve != null)
                {
                    double bgTone = background.GetTone(scheme);
                    double selfContrast = contrastCurve.Get(scheme.ContrastLevel);

                    if (Contrast.RatioOfTones(bgTone, selfTone) < selfContrast || scheme.ContrastLevel < 0)
                    {
                        selfTone = ForegroundToneCalculation.ForegroundTone(bgTone, selfContrast);
                    }
                }
            }

            // Awkward zone avoidance (except fixed dim colors)
            if (color.IsBackground && !color.Name.EndsWith("_fixed_dim"))
            {
                if (selfTone >= 57)
                    selfTone = Math.Clamp(selfTone, 65, 100);
                else
                    selfTone = Math.Clamp(selfTone, 0, 49);
            }

            return selfTone;
        }
        else
        {
            // Case 1: No tone delta pair; use base logic (which handles self-solving and backgrounds)
            // Note: The logic in 2025 GetTone for Case 1 is almost identical to 2021,
            // EXCEPT for the "Awkward Zone" logic at the end.
            // We will copy the implementation here to ensure the 2025 specific constraints are applied.

            double answer = color.Tone(scheme);

            if (color.Background == null || color.ContrastCurve == null)
                return answer;

            DynamicColor? bg = color.Background(scheme);
            ContrastCurve? curve = color.ContrastCurve(scheme);

            if (bg == null || curve == null)
                return answer;

            double bgTone = bg.GetTone(scheme);
            double desiredRatio = curve.Get(scheme.ContrastLevel);

            var ratioOfTones = Contrast.RatioOfTones(bgTone, answer);
            if (ratioOfTones < desiredRatio || scheme.ContrastLevel < 0)
            {
                answer = ForegroundToneCalculation.ForegroundTone(bgTone, desiredRatio);
            }

            // Awkward zone avoidance
            if (color.IsBackground && !color.Name.EndsWith("_fixed_dim"))
            {
                answer = answer >= 57
                    ? Math.Clamp(answer, 65, 100)
                    : Math.Clamp(answer, 0, 49);
            }

            DynamicColor? bg2 = color.SecondBackground?.Invoke(scheme);
            if (bg2 == null)
                return answer;

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

            List<double> availables = [];
            if (lightOption != -1)
                availables.Add(lightOption);
            if (darkOption != -1)
                availables.Add(darkOption);

            bool prefersLight = ForegroundToneCalculation.TonePrefersLightForeground(bgTone1) ||
                                ForegroundToneCalculation.TonePrefersLightForeground(bgTone2);

            if (prefersLight)
                return lightOption < 0 ? 100 : lightOption;
            if (availables.Count == 1)
                return availables[0];
            return darkOption < 0 ? 0 : darkOption;
        }
    }

    // ----------------------------------------------------------------
    // Scheme Palettes
    // ----------------------------------------------------------------

    public override TonalPalette GetPrimaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 12 : 8) : (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 16 : 12)),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone && isDark ? 26 : 32),
            Variant.Expressive => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? (isDark ? 36 : 48) : 40),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? 74 : 56),
            _ => base.GetPrimaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    public override TonalPalette GetSecondaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 6 : 4) : (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 10 : 6)),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16),
            Variant.Expressive => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 105, 140, 204, 253, 278, 300, 333, 360], [-160, 155, -100, 96, -96, -156, -165, -160]),
                platform == Platform.Phone ? (isDark ? 16 : 24) : 24),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 38, 105, 140, 333, 360], [-14, 10, -14, 10, -14]),
                platform == Platform.Phone ? 56 : 36),
            _ => base.GetSecondaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    public override TonalPalette GetTertiaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 38, 105, 161, 204, 278, 333, 360], [-32, 26, 10, -39, 24, -15, -32]),
                platform == Platform.Phone ? 20 : 36),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 20, 71, 161, 333, 360], [-40, 48, -32, 40, -32]),
                platform == Platform.Phone ? 28 : 32),
            Variant.Expressive => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 105, 140, 204, 253, 278, 300, 333, 360], [-165, 160, -105, 101, -101, -160, -170, -165]),
                48),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 38, 71, 105, 140, 161, 253, 333, 360], [-72, 35, 24, -24, 62, 50, 62, -72]),
                56),
            _ => base.GetTertiaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    public override TonalPalette GetNeutralPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? 1.4 : 6),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform == Platform.Phone ? 5 : 10),
            Variant.Expressive => TonalPalette.FromHueAndChroma(GetExpressiveNeutralHue(sourceColorHct), GetExpressiveNeutralChroma(sourceColorHct, isDark, platform)),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(GetVibrantNeutralHue(sourceColorHct), GetVibrantNeutralChroma(sourceColorHct, platform)),
            _ => base.GetNeutralPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    public override TonalPalette GetNeutralVariantPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, (platform == Platform.Phone ? 1.4 : 6) * 2.2),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, (platform == Platform.Phone ? 5 : 10) * 1.7),
            Variant.Expressive => TonalPalette.FromHueAndChroma(
                GetExpressiveNeutralHue(sourceColorHct),
                GetExpressiveNeutralChroma(sourceColorHct, isDark, platform) * (GetExpressiveNeutralHue(sourceColorHct) is >= 105 and < 125 ? 1.6 : 2.3)),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(
                GetVibrantNeutralHue(sourceColorHct),
                GetVibrantNeutralChroma(sourceColorHct, platform) * 1.29),
            _ => base.GetNeutralVariantPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    public override TonalPalette? GetErrorPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        double errorHue = DynamicScheme.GetPiecewiseValue(sourceColorHct.Hue,
            [0, 3, 13, 23, 33, 43, 153, 273, 360],
            [12, 22, 32, 12, 22, 32, 22, 12]);

        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(errorHue, platform == Platform.Phone ? 50 : 40),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(errorHue, platform == Platform.Phone ? 60 : 48),
            Variant.Expressive => TonalPalette.FromHueAndChroma(errorHue, platform == Platform.Phone ? 64 : 48),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(errorHue, platform == Platform.Phone ? 80 : 60),
            _ => base.GetErrorPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    // ----------------------------------------------------------------
    // Helpers
    // ----------------------------------------------------------------

    private static double FindBestToneForChroma(double hue, double chroma, double tone, bool byDecreasingTone)
    {
        double answer = tone;
        HctColor bestCandidate = HctColor.From(hue, chroma, answer);

        while (bestCandidate.Chroma < chroma)
        {
            if (tone is < 0 or > 100) break;

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

    private static double TMaxC(TonalPalette palette) => TMaxC(palette, 0, 100);

    private static double TMaxC(TonalPalette palette, double lowerBound, double upperBound) => TMaxC(palette, lowerBound, upperBound, 1);

    private static double TMaxC(TonalPalette palette, double lowerBound, double upperBound, double chromaMultiplier)
    {
        double answer = FindBestToneForChroma(palette.Hue, palette.Chroma * chromaMultiplier, 100, true);
        return Math.Clamp(answer, lowerBound, upperBound);
    }

    private static double TMinC(TonalPalette palette) => TMinC(palette, 0, 100);

    private static double TMinC(TonalPalette palette, double lowerBound, double upperBound)
    {
        double answer = FindBestToneForChroma(palette.Hue, palette.Chroma, 0, false);
        return Math.Clamp(answer, lowerBound, upperBound);
    }

    private static ContrastCurve GetContrastCurve(double defaultContrast)
    {
        return defaultContrast switch
        {
            1.5 => new ContrastCurve(1.5, 1.5, 3, 5.5),
            3 => new ContrastCurve(3, 3, 4.5, 7),
            4.5 => new ContrastCurve(4.5, 4.5, 7, 11),
            6 => new ContrastCurve(6, 6, 7, 11),
            7 => new ContrastCurve(7, 7, 11, 21),
            9 => new ContrastCurve(9, 9, 11, 21),
            11 => new ContrastCurve(11, 11, 21, 21),
            21 => new ContrastCurve(21, 21, 21, 21),
            _ => new ContrastCurve(defaultContrast, defaultContrast, 7, 21)
        };
    }

    private static double GetExpressiveNeutralHue(HctColor sourceColorHct)
    {
        return DynamicScheme.GetRotatedHue(sourceColorHct,
            [0, 71, 124, 253, 278, 300, 360],
            [10, 0, 10, 0, 10, 0]);
    }

    private static double GetExpressiveNeutralChroma(HctColor sourceColorHct, bool isDark, Platform platform)
    {
        double neutralHue = GetExpressiveNeutralHue(sourceColorHct);
        if (platform == Platform.Phone)
            return isDark ? (HctColorCategorization.IsYellow(neutralHue) ? 6 : 14) : 18;
        return 12;
    }

    private static double GetVibrantNeutralHue(HctColor sourceColorHct)
    {
        return DynamicScheme.GetRotatedHue(sourceColorHct,
            [0, 38, 105, 140, 333, 360],
            [-14, 10, -14, 10, -14]);
    }

    private static double GetVibrantNeutralChroma(HctColor sourceColorHct, Platform platform)
    {
        double neutralHue = GetVibrantNeutralHue(sourceColorHct);
        if (platform == Platform.Phone) return 28;
        return HctColorCategorization.IsBlue(neutralHue) ? 28 : 20;
    }
}
