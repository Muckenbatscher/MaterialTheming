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
    private DynamicColorBuilder CreateBackground()
    {
        return DynamicColorBuilder.Create(Surface)
            .WithName("background");
    }

    public override DynamicColor OnBackground => CreateOnBackground().Build();
    private DynamicColorBuilder CreateOnBackground()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_background")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.Platform.IsWatch() ? 100.0 : base.OnSurface.GetTone(s))
            .WithBackground(_ => Background)
            .WithContrastCurve(s => new ContrastCurve(3.0, 3.0, 4.5, 7.0));
    }

    public override DynamicColor Surface => CreateSurface().Build();
    private DynamicColorBuilder CreateSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.IsDark)
                        return 4.0;
                    if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue))
                        return 99.0;
                    if (s.Variant == Variant.Vibrant)
                        return 97.0;
                    return 98.0;
                }
                return 0.0;
            })
            .WithIsBackground(true);
    }

    public override DynamicColor SurfaceDim => CreateSurfaceDim().Build();
    private DynamicColorBuilder CreateSurfaceDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_dim")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.IsDark)
                    return 4.0;
                if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue))
                    return 90.0;
                if (s.Variant == Variant.Vibrant)
                    return 85.0;
                return 87.0;
            })
            .WithIsBackground(true)
            .WithChromaMultiplier(s =>
            {
                if (!s.IsDark)
                {
                    if (s.Variant == Variant.Neutral)
                        return 2.5;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.7;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 2.7 : 1.75;
                    if (s.Variant == Variant.Vibrant)
                        return 1.36;
                }
                return 1.0;
            });
    }

    public override DynamicColor SurfaceBright => CreateSurfaceBright().Build();
    private DynamicColorBuilder CreateSurfaceBright()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_bright")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.IsDark)
                    return 18.0;
                if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue))
                    return 99.0;
                if (s.Variant == Variant.Vibrant)
                    return 97.0;
                return 98.0;
            })
            .WithIsBackground(true)
            .WithChromaMultiplier(s =>
            {
                if (s.IsDark)
                {
                    if (s.Variant == Variant.Neutral)
                        return 2.5;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.7;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 2.7 : 1.75;
                    if (s.Variant == Variant.Vibrant)
                        return 1.36;
                }
                return 1.0;
            });
    }

    public override DynamicColor SurfaceContainerLowest => CreateSurfaceContainerLowest().Build();
    private DynamicColorBuilder CreateSurfaceContainerLowest()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_lowest")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 0.0 : 100.0)
            .WithIsBackground(true);
    }

    public override DynamicColor SurfaceContainerLow => CreateSurfaceContainerLow().Build();
    private DynamicColorBuilder CreateSurfaceContainerLow()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_low")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.IsDark)
                        return 6.0;
                    if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue))
                        return 98.0;
                    if (s.Variant == Variant.Vibrant)
                        return 95.0;
                    return 96.0;
                }
                return 15.0;
            })
            .WithIsBackground(true)
            .WithChromaMultiplier(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.Variant == Variant.Neutral)
                        return 1.3;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.25;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 1.3 : 1.15;
                    if (s.Variant == Variant.Vibrant)
                        return 1.08;
                }
                return 1.0;
            });
    }

    public override DynamicColor SurfaceContainer => CreateSurfaceContainer().Build();
    private DynamicColorBuilder CreateSurfaceContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.IsDark)
                        return 9.0;
                    if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue))
                        return 96.0;
                    if (s.Variant == Variant.Vibrant)
                        return 92.0;
                    return 94.0;
                }
                return 20.0;
            })
            .WithIsBackground(true)
            .WithChromaMultiplier(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.Variant == Variant.Neutral)
                        return 1.6;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.4;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 1.6 : 1.3;
                    if (s.Variant == Variant.Vibrant)
                        return 1.15;
                }
                return 1.0;
            });
    }

    public override DynamicColor SurfaceContainerHigh => CreateSurfaceContainerHigh().Build();
    private DynamicColorBuilder CreateSurfaceContainerHigh()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_high")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.IsDark)
                        return 12.0;
                    if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue))
                        return 94.0;
                    if (s.Variant == Variant.Vibrant)
                        return 90.0;
                    return 92.0;
                }
                return 25.0;
            })
            .WithIsBackground(true)
            .WithChromaMultiplier(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.Variant == Variant.Neutral)
                        return 1.9;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.5;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 1.95 : 1.45;
                    if (s.Variant == Variant.Vibrant)
                        return 1.22;
                }
                return 1.0;
            });
    }

    public override DynamicColor SurfaceContainerHighest => CreateSurfaceContainerHighest().Build();
    private DynamicColorBuilder CreateSurfaceContainerHighest()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_highest")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.IsDark)
                    return 15.0;
                if (HctColorCategorization.IsYellow(s.NeutralPalette.Hue))
                    return 92.0;
                if (s.Variant == Variant.Vibrant)
                    return 88.0;
                return 90.0;
            })
            .WithIsBackground(true)
            .WithChromaMultiplier(s =>
            {
                return s.Variant switch
                {
                    Variant.Neutral => 2.2,
                    Variant.TonalSpot => 1.7,
                    Variant.Expressive => HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? 2.3 : 1.6,
                    Variant.Vibrant => 1.29,
                    _ => 1.0
                };
            });
    }

    public override DynamicColor OnSurface => CreateOnSurface().Build();
    private DynamicColorBuilder CreateOnSurface()
    {
        DynamicColor backgroundFunc(DynamicScheme scheme)
        {
            if (scheme.Platform.IsPhone())
                return scheme.IsDark ? SurfaceBright : SurfaceDim;
            return SurfaceContainerHigh;
        }
        return DynamicColorBuilder.Create()
            .WithName("on_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.Vibrant)
                    return TMaxC(s.NeutralPalette, 0, 100, 1.1);
                var foregroundToneFunc = ForegroundToneCalculation.GetInitialToneFromBackground(backgroundFunc);
                return foregroundToneFunc(s);
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.Variant == Variant.Neutral)
                        return 2.2;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.7;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
                }
                return 1.0;
            })
            .WithBackground(backgroundFunc)
            .WithContrastCurve(s => s.IsDark && s.Platform.IsPhone() ? GetContrastCurve(11) : GetContrastCurve(9));
    }

    public override DynamicColor SurfaceVariant => CreateSurfaceVariant().Build();
    private DynamicColorBuilder CreateSurfaceVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_variant")
            .WithPalette(s => s.NeutralVariantPalette)
            .WithTone(SurfaceContainerHighest.GetTone)
            .WithIsBackground(true);
    }

    public override DynamicColor OnSurfaceVariant => CreateOnSurfaceVariant().Build();

    private DynamicColorBuilder CreateOnSurfaceVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_surface_variant")
            .WithPalette(s => s.NeutralPalette)
            .WithChromaMultiplier(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.Variant == Variant.Neutral)
                        return 2.2;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.7;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
                }
                return 1.0;
            })
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform.IsPhone()
            ? (s.IsDark ? GetContrastCurve(6) : GetContrastCurve(4.5))
            : GetContrastCurve(7));
    }

    public override DynamicColor InverseSurface => CreateInverseSurface().Build();
    private DynamicColorBuilder CreateInverseSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 98 : 4)
            .WithIsBackground(true);
    }

    public override DynamicColor InverseOnSurface => CreateInverseOnSurface().Build();
    private DynamicColorBuilder CreateInverseOnSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_on_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(base.InverseOnSurface.Tone)
            .WithBackground(_ => InverseSurface)
            .WithContrastCurve(_ => GetContrastCurve(7));
    }

    public override DynamicColor Outline => CreateOutline().Build();
    private DynamicColorBuilder CreateOutline()
    {
        return DynamicColorBuilder.Create()
            .WithName("outline")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(base.Outline.Tone)
            .WithChromaMultiplier(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.Variant == Variant.Neutral)
                        return 2.2;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.7;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
                }
                return 1.0;
            })
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(3) : GetContrastCurve(4.5));
    }

    public override DynamicColor OutlineVariant => CreateOutlineVariant().Build();
    private DynamicColorBuilder CreateOutlineVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("outline_variant")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(base.OutlineVariant.Tone)
            .WithChromaMultiplier(s =>
            {
                if (s.Platform.IsPhone())
                {
                    if (s.Variant == Variant.Neutral)
                        return 2.2;
                    if (s.Variant == Variant.TonalSpot)
                        return 1.7;
                    if (s.Variant == Variant.Expressive)
                        return HctColorCategorization.IsYellow(s.NeutralPalette.Hue) ? (s.IsDark ? 3.0 : 2.3) : 1.6;
                }
                return 1.0;
            })
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(1.5) : GetContrastCurve(3));
    }

    public override DynamicColor SurfaceTint => CreateSurfaceTint().Build();
    private DynamicColorBuilder CreateSurfaceTint()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_tint")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(Primary.GetTone)
            .WithIsBackground(true);
    }

    // ----------------------------------------------------------------
    // Primaries
    // ----------------------------------------------------------------

    public override DynamicColor Primary => CreatePrimary().Build();
    private DynamicColorBuilder CreatePrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.Neutral)
                {
                    if (s.Platform.IsPhone())
                        return s.IsDark ? 80.0 : 40.0;
                    return 90.0;
                }
                if (s.Variant == Variant.TonalSpot)
                {
                    if (s.Platform.IsPhone())
                    {
                        if (s.IsDark)
                            return 80.0;
                        return TMaxC(s.PrimaryPalette);
                    }
                    return TMaxC(s.PrimaryPalette, 0, 90);
                }
                if (s.Variant == Variant.Expressive)
                {
                    if (s.Platform.IsPhone())
                    {
                        return TMaxC(s.PrimaryPalette, 0, HctColorCategorization.IsYellow(s.PrimaryPalette.Hue) ? 25 : HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 98);
                    }
                    return TMaxC(s.PrimaryPalette); //Watch
                }
                // Vibrant
                if (s.Platform.IsPhone())
                {
                    return TMaxC(s.PrimaryPalette, 0, HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 98);
                }
                return TMaxC(s.PrimaryPalette);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(4.5) : GetContrastCurve(7))
            .WithToneDeltaPair(s => s.Platform.IsPhone()
                    ? new ToneDeltaPair(PrimaryContainer, Primary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
                    : null);
    }

    public override DynamicColor PrimaryDim => CreatePrimaryDim().Build();
    private DynamicColorBuilder CreatePrimaryDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_dim")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.Neutral)
                    return 85.0;
                if (s.Variant == Variant.TonalSpot)
                    return TMaxC(s.PrimaryPalette, 0, 90);
                return TMaxC(s.PrimaryPalette);
            })
            .WithIsBackground(true)
            .WithBackground(s => SurfaceContainerHigh)
            .WithContrastCurve(s => GetContrastCurve(4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(PrimaryDim, Primary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther));
    }

    public override DynamicColor OnPrimary => CreateOnPrimary().Build();
    private DynamicColorBuilder CreateOnPrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(s => s.Platform.IsPhone() ? Primary : PrimaryDim)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor PrimaryContainer => CreatePrimaryContainer().Build();
    private DynamicColorBuilder CreatePrimaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_container")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
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
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : null)
            .WithContrastCurve(s => s.Platform.IsPhone() && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null)
            .WithToneDeltaPair(s => s.Platform.IsWatch()
                ? new ToneDeltaPair(PrimaryContainer, PrimaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
                : null);
    }

    public override DynamicColor OnPrimaryContainer => CreateOnPrimaryContainer().Build();
    private DynamicColorBuilder CreateOnPrimaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_container")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(_ => PrimaryContainer)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor InversePrimary => CreateInversePrimary().Build();
    private DynamicColorBuilder CreateInversePrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => TMaxC(s.PrimaryPalette))
            .WithBackground(s => InverseSurface)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    // ----------------------------------------------------------------
    // Secondaries
    // ----------------------------------------------------------------

    public override DynamicColor Secondary => CreateSecondary().Build();
    private DynamicColorBuilder CreateSecondary()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                    return s.Variant == Variant.Neutral ? 90.0 : TMaxC(s.SecondaryPalette, 0, 90);
                if (s.Variant == Variant.Neutral)
                    return s.IsDark ? TMinC(s.SecondaryPalette, 0, 98) : TMaxC(s.SecondaryPalette);
                if (s.Variant == Variant.Vibrant)
                    return TMaxC(s.SecondaryPalette, 0, s.IsDark ? 90 : 98);
                return s.IsDark ? 80.0 : TMaxC(s.SecondaryPalette);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(4.5) : GetContrastCurve(7))
            .WithToneDeltaPair(s => s.Platform.IsPhone()
                ? new ToneDeltaPair(SecondaryContainer, Secondary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
                : null);
    }

    public override DynamicColor SecondaryDim => CreateSecondaryDim().Build();
    private DynamicColorBuilder CreateSecondaryDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_dim")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.Neutral)
                    return 85.0;
                return TMaxC(s.SecondaryPalette, 0, 90);
            })
            .WithIsBackground(true)
            .WithBackground(s => SurfaceContainerHigh)
            .WithContrastCurve(s => GetContrastCurve(4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(SecondaryDim, Secondary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther));
    }

    public override DynamicColor OnSecondary => CreateOnSecondary().Build();
    private DynamicColorBuilder CreateOnSecondary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(s => s.Platform.IsPhone() ? Secondary : SecondaryDim)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor SecondaryContainer => CreateSecondaryContainer().Build();
    private DynamicColorBuilder CreateSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                    return 30.0;
                if (s.Variant == Variant.Vibrant)
                    return s.IsDark ? TMinC(s.SecondaryPalette, 30, 40) : TMaxC(s.SecondaryPalette, 84, 90);
                if (s.Variant == Variant.Expressive)
                    return s.IsDark ? 15.0 : TMaxC(s.SecondaryPalette, 90, 95);
                return s.IsDark ? 25.0 : 90.0;
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : null)
            .WithContrastCurve(s => s.Platform.IsPhone() && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null)
            .WithToneDeltaPair(s => s.Platform.IsWatch()
                ? new ToneDeltaPair(SecondaryContainer, SecondaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
                : null);
    }

    public override DynamicColor OnSecondaryContainer => CreateOnSecondaryContainer().Build();
    private DynamicColorBuilder CreateOnSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => SecondaryContainer)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    // ----------------------------------------------------------------
    // Tertiaries
    // ----------------------------------------------------------------

    public override DynamicColor Tertiary => CreateTertiary().Build();
    private DynamicColorBuilder CreateTertiary()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                    return s.Variant == Variant.TonalSpot ? TMaxC(s.TertiaryPalette, 0, 90) : TMaxC(s.TertiaryPalette);

                if (s.Variant == Variant.Expressive || s.Variant == Variant.Vibrant)
                {
                    return TMaxC(s.TertiaryPalette, 0, HctColorCategorization.IsCyan(s.TertiaryPalette.Hue) ? 88 : (s.IsDark ? 98 : 100));
                }
                return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 98) : TMaxC(s.TertiaryPalette);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(4.5) : GetContrastCurve(7))
            .WithToneDeltaPair(s => s.Platform.IsPhone()
                ? new ToneDeltaPair(TertiaryContainer, Tertiary, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
                : null);
    }

    public override DynamicColor TertiaryDim => CreateTertiaryDim().Build();
    private DynamicColorBuilder CreateTertiaryDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_dim")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.TonalSpot)
                    return TMaxC(s.TertiaryPalette, 0, 90);
                return TMaxC(s.TertiaryPalette);
            })
            .WithIsBackground(true)
            .WithBackground(s => SurfaceContainerHigh)
            .WithContrastCurve(s => GetContrastCurve(4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(TertiaryDim, Tertiary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther));
    }

    public override DynamicColor OnTertiary => CreateOnTertiary().Build();
    private DynamicColorBuilder CreateOnTertiary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(s => s.Platform.IsPhone() ? Tertiary : TertiaryDim)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor TertiaryContainer => CreateTertiaryContainer().Build();
    private DynamicColorBuilder CreateTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
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
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : null)
            .WithContrastCurve(s => s.Platform.IsPhone() && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null)
            .WithToneDeltaPair(s => s.Platform.IsWatch()
                ? new ToneDeltaPair(TertiaryContainer, TertiaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
                : null);
    }

    public override DynamicColor OnTertiaryContainer => CreateOnTertiaryContainer().Build();
    private DynamicColorBuilder CreateOnTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => TertiaryContainer)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    // ----------------------------------------------------------------
    // Errors
    // ----------------------------------------------------------------

    public override DynamicColor Error => CreateError().Build();
    private DynamicColorBuilder CreateError()
    {
        return DynamicColorBuilder.Create()
            .WithName("error")
            .WithPalette(s => s.ErrorPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsPhone())
                    return s.IsDark ? TMinC(s.ErrorPalette, 0, 98) : TMaxC(s.ErrorPalette);
                return TMinC(s.ErrorPalette);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(4.5) : GetContrastCurve(7))
            .WithToneDeltaPair(s => s.Platform.IsPhone()
                ? new ToneDeltaPair(ErrorContainer, Error, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
                : null);
    }

    public override DynamicColor ErrorDim => CreateErrorDim().Build();
    private DynamicColorBuilder CreateErrorDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("error_dim")
            .WithPalette(s => s.ErrorPalette)
            .WithTone(s => TMinC(s.ErrorPalette))
            .WithIsBackground(true)
            .WithBackground(s => SurfaceContainerHigh)
            .WithContrastCurve(s => GetContrastCurve(4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(ErrorDim, Error, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther));
    }

    public override DynamicColor OnError => CreateOnError().Build();
    private DynamicColorBuilder CreateOnError()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error")
            .WithPalette(s => s.ErrorPalette)
            .WithBackground(s => s.Platform.IsPhone() ? Error : ErrorDim)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(6) : GetContrastCurve(7));
    }

    public override DynamicColor ErrorContainer => CreateErrorContainer().Build();
    private DynamicColorBuilder CreateErrorContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("error_container")
            .WithPalette(s => s.ErrorPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                    return 30.0;
                return s.IsDark ? TMinC(s.ErrorPalette, 30, 93) : TMaxC(s.ErrorPalette, 0, 90);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : null)
            .WithContrastCurve(s => s.Platform.IsPhone() && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null)
            .WithToneDeltaPair(s => s.Platform.IsWatch()
                ? new ToneDeltaPair(ErrorContainer, ErrorDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
                : null);
    }

    public override DynamicColor OnErrorContainer => CreateOnErrorContainer().Build();
    private DynamicColorBuilder CreateOnErrorContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error_container")
            .WithPalette(s => s.ErrorPalette)
            .WithBackground(s => ErrorContainer)
            .WithContrastCurve(s => s.Platform.IsPhone() ? GetContrastCurve(4.5) : GetContrastCurve(7));
    }

    // ----------------------------------------------------------------
    // Primary Fixed
    // ----------------------------------------------------------------

    public override DynamicColor PrimaryFixed => CreatePrimaryFixed().Build();
    private DynamicColorBuilder CreatePrimaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_fixed")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => PrimaryContainer.GetTone(DynamicScheme.From(s, false, 0.0)))
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : null)
            .WithContrastCurve(s => s.Platform.IsPhone() && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor PrimaryFixedDim => CreatePrimaryFixedDim().Build();
    private DynamicColorBuilder CreatePrimaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_fixed_dim")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => PrimaryFixed.GetTone(s))
            .WithIsBackground(true)
            .WithToneDeltaPair(s => new ToneDeltaPair(PrimaryFixedDim, PrimaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact));
    }

    public override DynamicColor OnPrimaryFixed => CreateOnPrimaryFixed().Build();
    private DynamicColorBuilder CreateOnPrimaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => base.OnPrimaryFixed.Tone(s))
            .WithBackground(s => PrimaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(7));
    }

    public override DynamicColor OnPrimaryFixedVariant => CreateOnPrimaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnPrimaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed_variant")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => base.OnPrimaryFixedVariant.Tone(s))
            .WithBackground(s => PrimaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(4.5));
    }

    // ----------------------------------------------------------------
    // Secondary Fixed
    // ----------------------------------------------------------------

    public override DynamicColor SecondaryFixed => CreateSecondaryFixed().Build();
    private DynamicColorBuilder CreateSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => SecondaryContainer.GetTone(DynamicScheme.From(s, false, 0.0)))
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : null)
            .WithContrastCurve(s => s.Platform.IsPhone() && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor SecondaryFixedDim => CreateSecondaryFixedDim().Build();
    private DynamicColorBuilder CreateSecondaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_fixed_dim")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => SecondaryFixed.GetTone(s))
            .WithIsBackground(true)
            .WithToneDeltaPair(s => new ToneDeltaPair(SecondaryFixedDim, SecondaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact));
    }

    public override DynamicColor OnSecondaryFixed => CreateOnSecondaryFixed().Build();
    private DynamicColorBuilder CreateOnSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => base.OnSecondaryFixed.Tone(s))
            .WithBackground(s => SecondaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(7));
    }

    public override DynamicColor OnSecondaryFixedVariant => CreateOnSecondaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnSecondaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed_variant")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => base.OnSecondaryFixedVariant.Tone(s))
            .WithBackground(s => SecondaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(4.5));
    }

    // ----------------------------------------------------------------
    // Tertiary Fixed
    // ----------------------------------------------------------------

    public override DynamicColor TertiaryFixed => CreateTertiaryFixed().Build();
    private DynamicColorBuilder CreateTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => TertiaryContainer.GetTone(DynamicScheme.From(s, false, 0.0)))
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : null)
            .WithContrastCurve(s => s.Platform.IsPhone() && s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor TertiaryFixedDim => CreateTertiaryFixedDim().Build();
    private DynamicColorBuilder CreateTertiaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_fixed_dim")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => TertiaryFixed.GetTone(s))
            .WithIsBackground(true)
            .WithToneDeltaPair(s => new ToneDeltaPair(TertiaryFixedDim, TertiaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact));
    }

    public override DynamicColor OnTertiaryFixed => CreateOnTertiaryFixed().Build();
    private DynamicColorBuilder CreateOnTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => base.OnTertiaryFixed.Tone(s))
            .WithBackground(s => TertiaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(7));
    }

    public override DynamicColor OnTertiaryFixedVariant => CreateOnTertiaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnTertiaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed_variant")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => base.OnTertiaryFixedVariant.Tone(s))
            .WithBackground(s => TertiaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(4.5));
    }

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
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() ? (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 12 : 8) : (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 16 : 12)),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() && isDark ? 26 : 32),
            Variant.Expressive => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() ? (isDark ? 36 : 48) : 40),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() ? 74 : 56),
            _ => base.GetPrimaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    public override TonalPalette GetSecondaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() ? (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 6 : 4) : (HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 10 : 6)),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16),
            Variant.Expressive => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 105, 140, 204, 253, 278, 300, 333, 360], [-160, 155, -100, 96, -96, -156, -165, -160]),
                platform.IsPhone() ? (isDark ? 16 : 24) : 24),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 38, 105, 140, 333, 360], [-14, 10, -14, 10, -14]),
                platform.IsPhone() ? 56 : 36),
            _ => base.GetSecondaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    public override TonalPalette GetTertiaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 38, 105, 161, 204, 278, 333, 360], [-32, 26, 10, -39, 24, -15, -32]),
                platform.IsPhone() ? 20 : 36),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(
                DynamicScheme.GetRotatedHue(sourceColorHct, [0, 20, 71, 161, 333, 360], [-40, 48, -32, 40, -32]),
                platform.IsPhone() ? 28 : 32),
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
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() ? 1.4 : 6),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() ? 5 : 10),
            Variant.Expressive => TonalPalette.FromHueAndChroma(GetExpressiveNeutralHue(sourceColorHct), GetExpressiveNeutralChroma(sourceColorHct, isDark, platform)),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(GetVibrantNeutralHue(sourceColorHct), GetVibrantNeutralChroma(sourceColorHct, platform)),
            _ => base.GetNeutralPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
        };
    }

    public override TonalPalette GetNeutralVariantPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        return variant switch
        {
            Variant.Neutral => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() ? 3.08 : 13.2),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(sourceColorHct.Hue, platform.IsPhone() ? 8.5 : 17),
            Variant.Expressive => TonalPalette.FromHueAndChroma(
                GetExpressiveNeutralHue(sourceColorHct),
                GetExpressiveNeutralChroma(sourceColorHct, isDark, platform) * (HctColorCategorization.IsYellow(GetExpressiveNeutralHue(sourceColorHct)) ? 1.6 : 2.3)),
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
            Variant.Neutral => TonalPalette.FromHueAndChroma(errorHue, platform.IsPhone() ? 50 : 40),
            Variant.TonalSpot => TonalPalette.FromHueAndChroma(errorHue, platform.IsPhone() ? 60 : 48),
            Variant.Expressive => TonalPalette.FromHueAndChroma(errorHue, platform.IsPhone() ? 64 : 48),
            Variant.Vibrant => TonalPalette.FromHueAndChroma(errorHue, platform.IsPhone() ? 80 : 60),
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
            if (tone is < 0 or > 100)
                break;

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
        if (platform.IsPhone())
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
        if (platform.IsPhone())
            return 28;
        return HctColorCategorization.IsBlue(neutralHue) ? 28 : 20;
    }
}
