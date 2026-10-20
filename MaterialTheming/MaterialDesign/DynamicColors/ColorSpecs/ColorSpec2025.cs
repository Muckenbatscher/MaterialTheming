using MaterialTheming.MaterialDesign.Contrasts;
using MaterialTheming.MaterialDesign.Hct;
using MaterialTheming.MaterialDesign.Palettes;
#if NETFRAMEWORK || NETSTANDARD
using MaterialTheming.System.Double.Extension;
#endif

namespace MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;

internal class ColorSpec2025 : ColorSpec2021
{
    // ----------------------------------------------------------------
    // Surfaces
    // ----------------------------------------------------------------

    public override DynamicColor Background => CreateBackground().Build();
    private DynamicColorBuilder CreateBackground()
    {
        return CreateSurface()
            .WithName("background");
    }

    public override DynamicColor OnBackground => CreateOnBackground().Build();
    private DynamicColorBuilder CreateOnBackground()
    {
        return CreateOnSurface()
            .WithName("on_background")
            .WithTone(s => s.Platform.IsWatch() ? 100.0 : OnSurface.GetTone(s));
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
                if (!s.IsDark && s.Platform.IsPhone())
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
                if (s.IsDark || s.Platform.IsWatch())
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
                if (s.IsDark || s.Platform.IsWatch())
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
            .WithTone(s => s.IsDark || s.Platform.IsWatch() ? 0.0 : 100.0)
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
                if (s.IsDark || s.Platform.IsWatch())
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
                if (s.Platform.IsPhone() && s.Variant == Variant.Vibrant)
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
            .WithContrastCurve(s =>
            {
                if (s.Platform.IsPhone())
                {
                    return s.IsDark
                        ? GetContrastCurve(11)
                        : GetContrastCurve(9);
                }
                return new ContrastCurve(4.5, 9, 11, 21);
            });
    }

    public override DynamicColor SurfaceVariant => CreateSurfaceVariant().Build();
    private DynamicColorBuilder CreateSurfaceVariant()
    {
        return CreateSurfaceContainerHighest()
            .WithName("surface_variant");
    }

    public override DynamicColor OnSurfaceVariant => CreateOnSurfaceVariant().Build();

    private DynamicColorBuilder CreateOnSurfaceVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_surface_variant")
            .WithPalette(s => s.Platform.IsWatch() ? s.NeutralVariantPalette : s.NeutralPalette)
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
            .WithContrastCurve(s =>
            {
                if (s.Platform.IsPhone())
                {
                    return s.IsDark ? GetContrastCurve(6) : GetContrastCurve(4.5);
                }
                return new ContrastCurve(3, 7, 7, 11);
            });
    }

    public override DynamicColor InverseSurface => CreateInverseSurface().Build();
    private DynamicColorBuilder CreateInverseSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark || s.Platform.IsWatch() ? 98 : 4)
            .WithIsBackground(true);
    }

    public override DynamicColor InverseOnSurface => CreateInverseOnSurface().Build();
    private DynamicColorBuilder CreateInverseOnSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_on_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithBackground(_ => InverseSurface)
            .WithContrastCurve(_ => GetContrastCurve(7));
    }

    public override DynamicColor Outline => CreateOutline().Build();
    private DynamicColorBuilder CreateOutline()
    {
        return DynamicColorBuilder.Create()
            .WithName("outline")
            .WithPalette(s => s.Platform.IsWatch() ? s.NeutralVariantPalette : s.NeutralPalette)
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
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? GetContrastCurve(3)
                    : new ContrastCurve(1.5, 4.5, 4.5, 7);
            });
    }

    public override DynamicColor OutlineVariant => CreateOutlineVariant().Build();
    private DynamicColorBuilder CreateOutlineVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("outline_variant")
            .WithPalette(s => s.Platform.IsWatch() ? s.NeutralVariantPalette : s.NeutralPalette)
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
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? GetContrastCurve(1.5)
                    : new ContrastCurve(1, 3, 3, 4.5);
            });
    }

    public override DynamicColor SurfaceTint => CreateSurfaceTint().Build();
    private DynamicColorBuilder CreateSurfaceTint()
    {
        return CreatePrimary()
            .WithName("surface_tint");
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
                if (s.Platform.IsWatch())
                {
                    if (s.Variant == Variant.Neutral)
                        return 90;

                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return MainTone(s.PrimaryPalette, maxTone);
                }
                if (s.Variant == Variant.Neutral)
                    return s.IsDark ? 80.0 : 40.0;
                if (s.Variant == Variant.TonalSpot)
                    return s.IsDark ? 80.0 : TMaxC(s.PrimaryPalette);
                if (s.Variant == Variant.Expressive)
                {
                    var upperbound = s.IsDark
                        ? (HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 98)
                        : (HctColorCategorization.IsYellow(s.PrimaryPalette.Hue) ? 25 : 98);
                    return TMaxC(s.PrimaryPalette, 0, upperbound);
                }
                var upperBound = HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 98;
                return TMaxC(s.PrimaryPalette, 0, upperBound);
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
                if (s.Platform.IsWatch())
                {
                    if (s.Variant == Variant.Neutral)
                        return 85.0;

                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return DimTone(s.PrimaryPalette, maxTone);
                }
                if (s.Variant == Variant.TonalSpot)
                    return TMaxC(s.PrimaryPalette, 0, 90);

                return TMaxC(s.PrimaryPalette);
            })
            .WithIsBackground(true)
            .WithBackground(s => SurfaceContainerHigh)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(4.5, 4.5, 4.5, 4.5)
                    : GetContrastCurve(4.5);
            })
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsWatch()
                    ? null
                    : new ToneDeltaPair(PrimaryDim, Primary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther);
            });
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
                        ? TMinC(s.PrimaryPalette, 30, 93)
                        : TMaxC(s.PrimaryPalette, 78, HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 90);
                }
                // Vibrant
                return s.IsDark
                    ? TMinC(s.PrimaryPalette, 66, 93)
                    : TMaxC(s.PrimaryPalette, 66, HctColorCategorization.IsCyan(s.PrimaryPalette.Hue) ? 88 : 93);
            })
            .WithIsBackground(true)
            .WithBackground(s =>
            {
                if (s.Platform.IsPhone())
                    return s.IsDark ? SurfaceBright : SurfaceDim;
                else
                    return SurfaceContainerHigh;
            })
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
                    : new ContrastCurve(1, 1, 1, 1);
            })
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
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? GetContrastCurve(6)
                    : new ContrastCurve(3, 7, 7, 11);
            });
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
                    return s.Variant == Variant.Neutral
                        ? 90.0
                        : MainTone(s.SecondaryPalette, 90);
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
                if (s.Platform.IsWatch())
                    return s.Variant == Variant.Neutral
                        ? 85
                        : DimTone(s.SecondaryPalette, 90);
                if (s.Variant == Variant.Neutral)
                    return 85.0;
                return TMaxC(s.SecondaryPalette, 0, 90);
            })
            .WithIsBackground(true)
            .WithBackground(s => SurfaceContainerHigh)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(4.5, 4.5, 4.5, 4.5)
                    : GetContrastCurve(4.5);
            })
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsWatch()
                    ? null
                    : new ToneDeltaPair(SecondaryDim, Secondary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther);
            });
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
            .WithBackground(s =>
            {
                return s.Platform.IsPhone()
                    ? s.IsDark ? SurfaceBright : SurfaceDim
                    : SurfaceContainerHigh;
            })
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsWatch()
                    ? new ToneDeltaPair(SecondaryContainer, SecondaryDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
                    : null;
            })
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
                    : new ContrastCurve(1, 1, 3, 4.5);
            });
    }

    public override DynamicColor OnSecondaryContainer => CreateOnSecondaryContainer().Build();
    private DynamicColorBuilder CreateOnSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => SecondaryContainer)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? GetContrastCurve(6)
                    : new ContrastCurve(3, 7, 7, 11);
            });
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
                {
                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return MainTone(s.TertiaryPalette, maxTone);
                }

                if (s.Variant == Variant.Expressive || s.Variant == Variant.Vibrant)
                    return TMaxC(s.TertiaryPalette, 0, HctColorCategorization.IsCyan(s.TertiaryPalette.Hue) ? 88 : (s.IsDark ? 98 : 100));

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
                if (s.Platform.IsWatch())
                {
                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return DimTone(s.TertiaryPalette, maxTone);
                }

                if (s.Variant == Variant.TonalSpot)
                    return TMaxC(s.TertiaryPalette, 0, 90);
                return TMaxC(s.TertiaryPalette);
            })
            .WithIsBackground(true)
            .WithBackground(s => SurfaceContainerHigh)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(4.5, 4.5, 4.5, 4.5)
                    : GetContrastCurve(4.5);
            })
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsWatch()
                    ? null
                    : new ToneDeltaPair(TertiaryDim, Tertiary, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Farther);
            });
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
                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return ContainerTone(s.TertiaryPalette, maxTone);
                }

                if (s.Variant == Variant.Neutral)
                    return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 93) : TMaxC(s.TertiaryPalette, 0, 96);

                if (s.Variant == Variant.TonalSpot)
                    return TMaxC(s.TertiaryPalette, 0, s.IsDark ? 93 : 100);

                if (s.Variant == Variant.Expressive)
                    return TMaxC(s.TertiaryPalette, 75, HctColorCategorization.IsCyan(s.TertiaryPalette.Hue) ? 88 : (s.IsDark ? 93 : 100));

                // Vibrant
                return s.IsDark ? TMaxC(s.TertiaryPalette, 0, 93) : TMaxC(s.TertiaryPalette, 72, 100);
            })
            .WithIsBackground(true)
            .WithBackground(s =>
            {
                return s.Platform.IsPhone()
                    ? s.IsDark ? SurfaceBright : SurfaceDim
                    : SurfaceContainerHigh;
            })
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
                    : new ContrastCurve(1, 1, 3, 4.5);
            });
    }

    public override DynamicColor OnTertiaryContainer => CreateOnTertiaryContainer().Build();
    private DynamicColorBuilder CreateOnTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => TertiaryContainer)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? GetContrastCurve(6)
                    : new ContrastCurve(3, 7, 7, 11);
            });
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

                var startingTone = ForegroundToneCalculation.ForegroundTone(bgTone: 25, ratio: 7);
                return FindDesiredChromaByTone(s.ErrorPalette.Hue, s.ErrorPalette.Chroma, startingTone, 100);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsPhone() ? (s.IsDark ? SurfaceBright : SurfaceDim) : SurfaceContainerHigh)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? GetContrastCurve(4.5)
                    : new ContrastCurve(3, 7, 7, 7);
            })
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsPhone()
                    ? new ToneDeltaPair(ErrorContainer, Error, 5.0, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther)
                    : null;
            });
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
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? GetContrastCurve(6)
                    : new ContrastCurve(4.5, 7, 11, 21);
            });
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
            .WithBackground(s =>
            {
                return s.Platform.IsPhone()
                    ? s.IsDark ? SurfaceBright : SurfaceDim
                    : SurfaceContainerHigh;
            })
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
                    : new ContrastCurve(1, 1, 3, 4.5);
            })
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsWatch()
                    ? new ToneDeltaPair(ErrorContainer, ErrorDim, 10.0, TonePolarity.Darker, ToneDeltaConstraint.Farther)
                    : null;
            });
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
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                {
                    if (s.Variant == Variant.Neutral)
                        return 90;

                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return MainTone(s.PrimaryPalette, maxTone);
                }

                var scheme = DynamicScheme.From(s, isDark: false, contrastLevel: 0.0);
                return PrimaryContainer.GetTone(scheme);
            })
            .WithIsBackground(true)
            .WithBackground(s =>
            {
                return s.Platform.IsPhone()
                    ? s.IsDark ? SurfaceBright : SurfaceDim
                    : SurfaceContainerHigh;
            })
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
                    : new ContrastCurve(7, 7, 7, 7);
            });
    }

    public override DynamicColor PrimaryFixedDim => CreatePrimaryFixedDim().Build();
    private DynamicColorBuilder CreatePrimaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_fixed_dim")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                {
                    if (s.Variant == Variant.Neutral)
                        return 85;
                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return DimTone(s.PrimaryPalette, maxTone);
                }
                return PrimaryFixed.GetTone(s);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsWatch() ? SurfaceContainerHigh : null)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(4.5, 4.5, 4.5, 4.5)
                    : null;
            })
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsWatch()
                    ? null
                    : new ToneDeltaPair(PrimaryFixedDim, PrimaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact);
            });
    }

    public override DynamicColor OnPrimaryFixed => CreateOnPrimaryFixed().Build();
    private DynamicColorBuilder CreateOnPrimaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(s => PrimaryFixedDim)
            .WithSecondBackground(s => s.Platform.IsWatch() ? PrimaryFixed : null)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(4.5, 7, 11, 21)
                    : GetContrastCurve(7);
            });
    }

    public override DynamicColor OnPrimaryFixedVariant => CreateOnPrimaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnPrimaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed_variant")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                    return 30;

                var func = ForegroundToneCalculation.GetInitialToneFromBackground(_ => PrimaryFixedDim);
                return func(s);
            })
            .WithBackground(s => PrimaryFixedDim)
            .WithSecondBackground(s => s.Platform.IsWatch() ? PrimaryFixed : null)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(3, 4.5, 7, 11)
                    : GetContrastCurve(4.5);
            });
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
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                {
                    return s.Variant == Variant.Neutral
                        ? 90
                        : MainTone(s.SecondaryPalette, 90);
                }

                var scheme = DynamicScheme.From(s, isDark: false, contrastLevel: 0.0);
                return SecondaryContainer.GetTone(scheme);
            })
            .WithIsBackground(true)
            .WithBackground(s =>
            {
                return s.Platform.IsPhone()
                    ? s.IsDark ? SurfaceBright : SurfaceDim
                    : SurfaceContainerHigh;
            })
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
                    : new ContrastCurve(7, 7, 7, 7);
            });
    }

    public override DynamicColor SecondaryFixedDim => CreateSecondaryFixedDim().Build();
    private DynamicColorBuilder CreateSecondaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_fixed_dim")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                {
                    return s.Variant == Variant.Neutral
                        ? 85
                        : DimTone(s.SecondaryPalette, 90);
                }
                return SecondaryFixed.GetTone(s);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsWatch() ? SurfaceContainerHigh : null)
            .WithContrastCurve(s => s.Platform.IsWatch() ? new ContrastCurve(4.5, 4.5, 4.5, 4.5) : null)
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsWatch()
                    ? null
                    : new ToneDeltaPair(SecondaryFixedDim, SecondaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact);
            });
    }

    public override DynamicColor OnSecondaryFixed => CreateOnSecondaryFixed().Build();
    private DynamicColorBuilder CreateOnSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(s => SecondaryFixedDim)
            .WithSecondBackground(s => s.Platform.IsWatch() ? SecondaryFixed : null)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(4.5, 7, 11, 21)
                    : GetContrastCurve(7);
            });
    }

    public override DynamicColor OnSecondaryFixedVariant => CreateOnSecondaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnSecondaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed_variant")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                    return 30;
                var func = ForegroundToneCalculation.GetInitialToneFromBackground(_ => SecondaryFixedDim);
                return func(s);
            })
            .WithBackground(s => SecondaryFixedDim)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(3, 4.5, 7, 11)
                    : GetContrastCurve(4.5);
            });
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
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                {
                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return MainTone(s.TertiaryPalette, maxTone);
                }
                var scheme = DynamicScheme.From(s, isDark: false, contrastLevel: 0.0);
                return TertiaryContainer.GetTone(scheme);
            })
            .WithIsBackground(true)
            .WithBackground(s =>
            {
                return s.Platform.IsPhone()
                    ? s.IsDark ? SurfaceBright : SurfaceDim
                    : SurfaceContainerHigh;
            })
            .WithContrastCurve(s =>
            {
                return s.Platform.IsPhone()
                    ? s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null
                    : new ContrastCurve(7, 7, 7, 7);
            });
    }

    public override DynamicColor TertiaryFixedDim => CreateTertiaryFixedDim().Build();
    private DynamicColorBuilder CreateTertiaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_fixed_dim")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                {
                    var maxTone = s.Variant == Variant.TonalSpot ? 90 : 100;
                    return DimTone(s.TertiaryPalette, maxTone);
                }
                return TertiaryFixed.GetTone(s);
            })
            .WithIsBackground(true)
            .WithBackground(s => s.Platform.IsWatch() ? SurfaceContainerHigh : null)
            .WithContrastCurve(s => s.Platform.IsWatch() ? new ContrastCurve(4.5, 4.5, 4.5, 4.5) : null)
            .WithToneDeltaPair(s =>
            {
                return s.Platform.IsWatch()
                    ? null
                    : new ToneDeltaPair(TertiaryFixedDim, TertiaryFixed, 5.0, TonePolarity.Darker, ToneDeltaConstraint.Exact);
            });
    }

    public override DynamicColor OnTertiaryFixed => CreateOnTertiaryFixed().Build();
    private DynamicColorBuilder CreateOnTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(s => TertiaryFixedDim)
            .WithSecondBackground(s => s.Platform.IsWatch() ? TertiaryFixed : null)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(4.5, 7, 11, 21)
                    : GetContrastCurve(7);
            });
    }

    public override DynamicColor OnTertiaryFixedVariant => CreateOnTertiaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnTertiaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed_variant")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (s.Platform.IsWatch())
                    return 30;

                var func = ForegroundToneCalculation.GetInitialToneFromBackground(_ => TertiaryFixedDim);
                return func(s);
            })
            .WithBackground(s => TertiaryFixedDim)
            .WithSecondBackground(s => s.Platform.IsWatch() ? TertiaryFixed : null)
            .WithContrastCurve(s =>
            {
                return s.Platform.IsWatch()
                    ? new ContrastCurve(3, 4.5, 7, 11)
                    : GetContrastCurve(4.5);
            });
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
        if (chromaMultiplier == 1.0)
            return palette.GetHct(tone);
        double chroma = palette.Chroma * chromaMultiplier;
        if (tone == 99.0 && HctColorCategorization.IsYellow(hue))
            return TonalPalette.FromHueAndChroma(hue, chroma).GetHct(tone);

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
                    selfTone = double.Clamp(referenceTone + relativeDelta, 0, 100);
                    break;
                case ToneDeltaConstraint.Nearer:
                    if (relativeDelta > 0)
                        selfTone = double.Clamp(double.Clamp(selfTone, referenceTone, referenceTone + relativeDelta), 0, 100);
                    else
                        selfTone = double.Clamp(double.Clamp(selfTone, referenceTone + relativeDelta, referenceTone), 0, 100);
                    break;
                case ToneDeltaConstraint.Farther:
                    if (relativeDelta > 0)
                        selfTone = double.Clamp(selfTone, referenceTone + relativeDelta, 100);
                    else
                        selfTone = double.Clamp(selfTone, 0, referenceTone + relativeDelta);
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
            if (scheme.Platform.IsPhone() && color.IsBackground && !color.Name.EndsWith("_fixed_dim"))
            {
                selfTone = selfTone >= 57
                    ? double.Clamp(selfTone, 65, 100)
                    : double.Clamp(selfTone, 0, 49);
            }

            return selfTone;
        }
        else
        {
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
            if (scheme.Platform.IsPhone() && color.IsBackground && !color.Name.EndsWith("_fixed_dim"))
            {
                answer = answer >= 57
                    ? double.Clamp(answer, 65, 100)
                    : double.Clamp(answer, 0, 49);
            }
            else if (scheme.Platform.IsWatch() && color.IsBackground && 50 <= answer && answer < 60)
            {
                answer = Contrast.RatioOfTones(49, bgTone) >= desiredRatio
                    ? 49
                    : 60;
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
        if (variant is Variant.Neutral)
        {
            var chroma = platform.IsPhone()
                ? HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 12 : 8
                : IsWatchBlueHue(sourceColorHct) ? 16 : 12;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.TonalSpot)
        {
            var chroma = platform.IsPhone() && isDark ? 26 : 32;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.Expressive)
        {
            var chroma = platform.IsPhone()
                ? isDark ? 36 : 48
                : 40;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.Vibrant)
        {
            var chroma = platform.IsPhone() ? 74 : 56;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.Content && platform.IsWatch())
        {
            return TonalPalette.FromHct(sourceColorHct);
        }

        return base.GetPrimaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    public override TonalPalette GetSecondaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (variant is Variant.Neutral)
        {
            var chroma = platform.IsPhone()
                ? HctColorCategorization.IsBlue(sourceColorHct.Hue) ? 6 : 4
                : IsWatchBlueHue(sourceColorHct) ? 10 : 6;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.TonalSpot)
        {
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, 16);
        }
        if (variant is Variant.Expressive)
        {
            double[] hueBreakPoints = platform.IsWatch()
                ? [0, 21, 51, 121, 151, 191, 271, 321, 360]
                : [204, 175, 155, 150, 204, 260, 204, 204, 204];
            double[] hueRotations = platform.IsWatch()
                ? [0, 105, 140, 204, 253, 278, 300, 333, 360]
                : [-160, 155, -100, 96, -96, -156, -165, -160];
            var hue = DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakPoints, hueRotations);
            var chroma = platform.IsPhone()
                ? isDark ? 16 : 24
                : 24;
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }
        if (variant is Variant.Vibrant)
        {
            double[] hueBreakPoints = platform.IsWatch()
               ? [0, 41, 61, 101, 131, 181, 251, 301, 360]
               : [-14, 0, 355, 357, 0, 3, 10, 331, 331];
            double[] hueRotations = platform.IsWatch()
                ? [0, 38, 105, 140, 333, 360]
                : [-14, 10, -14, 10, -14];
            var hue = DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakPoints, hueRotations);
            var chroma = platform.IsPhone() ? 56 : 36;
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }
        if (variant is Variant.Content && platform.IsWatch())
        {
            double halfChroma = sourceColorHct.Chroma / 2;
            var chroma = Math.Clamp(halfChroma, 16, 36);
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }

        return base.GetSecondaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    public override TonalPalette GetTertiaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (variant is Variant.Neutral)
        {
            double[] hueBreakpoints = platform.IsWatch()
                ? [0, 41, 61, 101, 131, 181, 250, 270, 360]
                : [25, 25, 26, 25, -39, 25, 28, 25, 25];
            double[] hueRotations = platform.IsWatch()
                ? [0, 38, 105, 161, 204, 278, 333, 360]
                : [-32, 26, 10, -39, 24, -15, -32];
            var hue = DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakpoints, hueRotations);
            var chroma = platform.IsPhone() ? 20 : 36;
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }
        if (variant is Variant.TonalSpot)
        {
            double[] hueBreakpoints = platform.IsWatch()
                ? [0, 40, 101, 210, 301, 360]
                : [0, 20, 71, 161, 333, 360];
            double[] hueRotations = platform.IsWatch()
                ? [-32, 32, -32, 32, -32, -32]
                : [-40, 48, -32, 40, -32];
            var hue = DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakpoints, hueRotations);
            var chroma = platform.IsPhone() ? 28 : 32;
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }
        if (variant is Variant.Expressive)
        {
            double[] hueBreakpoints = platform.IsWatch()
                ? [0, 21, 51, 121, 151, 191, 271, 321, 360]
                : [0, 105, 140, 204, 253, 278, 300, 333, 360];
            double[] hueRotations = platform.IsWatch()
                ? [200, 200, 160, 169, 200, 220, 200, 200, 200]
                : [-165, 160, -105, 101, -101, -160, -170, -165];
            var hue = DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakpoints, hueRotations);
            return TonalPalette.FromHueAndChroma(hue, chroma: 48);
        }
        if (variant is Variant.Vibrant)
        {
            double[] hueBreakpoints = platform.IsWatch()
                ? [0, 41, 61, 101, 131, 181, 251, 301, 360]
                : [0, 38, 71, 105, 140, 161, 253, 333, 360];
            double[] hueRotations = platform.IsWatch()
                ? [-72, 55, 45, 50, 55, 50, 62, 303, 303]
                : [-72, 35, 24, -24, 62, 50, 62, -72];
            var hue = DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakpoints, hueRotations);
            var chroma = platform.IsPhone() ? 56 : 48;
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }
        if (variant is Variant.Content && platform.IsWatch())
        {
            double[] hueBreakpoints = [0, 40, 101, 210, 301, 360];
            double[] hueRotations = [-32, 32, -32, 32, -32, -32];
            var hue = DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakpoints, hueRotations);
            return TonalPalette.FromHueAndChroma(hue, sourceColorHct.Chroma);
        }

        return base.GetTertiaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    public override TonalPalette GetNeutralPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (variant is Variant.Neutral)
        {
            var chroma = platform.IsPhone() ? 1.4 : 6;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.TonalSpot)
        {
            var chroma = platform.IsPhone() ? 5 : 10;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.Expressive)
        {
            var hue = GetExpressiveNeutralHue(sourceColorHct, platform);
            var chroma = GetExpressiveNeutralChroma(sourceColorHct, isDark, platform);
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }
        if (variant is Variant.Vibrant)
        {
            var hue = GetVibrantNeutralHue(sourceColorHct, platform);
            var chroma = GetVibrantNeutralChroma(sourceColorHct, platform);
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }
        if (variant is Variant.Content && platform.IsWatch())
        {
            var thirdChroma = sourceColorHct.Chroma * 0.333;
            var chroma = Math.Clamp(thirdChroma, 6, 20);
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }

        return base.GetNeutralPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    public override TonalPalette GetNeutralVariantPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (platform.IsWatch())
        {
            Variant[] neutralPaletteVariants = [Variant.Neutral, Variant.TonalSpot, Variant.Expressive, Variant.Vibrant, Variant.Content];
            return neutralPaletteVariants.Contains(variant)
                ? GetNeutralPalette(variant, sourceColorHct, isDark, platform, contrastLevel)
                : base.GetNeutralVariantPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
        }

        if (variant is Variant.Neutral)
        {
            var chroma = platform.IsPhone() ? 3.08 : 13.2;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.TonalSpot)
        {
            var chroma = platform.IsPhone() ? 8.5 : 17;
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, chroma);
        }
        if (variant is Variant.Expressive)
        {
            var hue = GetExpressiveNeutralHue(sourceColorHct, platform);
            var chromaMultiplier = HctColorCategorization.IsYellow(GetExpressiveNeutralHue(sourceColorHct, platform)) ? 1.6 : 2.3;
            var chroma = GetExpressiveNeutralChroma(sourceColorHct, isDark, platform) * chromaMultiplier;
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }
        if (variant is Variant.Vibrant)
        {
            var hue = GetVibrantNeutralHue(sourceColorHct, platform);
            var chroma = GetVibrantNeutralChroma(sourceColorHct, platform) * 1.29;
            return TonalPalette.FromHueAndChroma(hue, chroma);
        }

        return base.GetNeutralVariantPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
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

    private static bool IsCloseToChroma(HctColor hct, double chroma)
    {
        return Math.Abs(hct.Chroma - chroma) < 0.4;
    }

    private static double FindDesiredChromaByTone(
        double hue, double chroma, double startingTone, double endingTone)
    {
        if (endingTone == startingTone)
        {
            return startingTone;
        }

        double answer = startingTone;
        double potentialAnswer = answer;

        var closestToChroma = HctColor.From(hue, chroma, startingTone);
        if (closestToChroma.Chroma < chroma && !IsCloseToChroma(closestToChroma, chroma))
        {
            while (closestToChroma.Chroma < chroma)
            {
                double increment = endingTone < startingTone ? -1.0 : 1.0;
                potentialAnswer += increment;

                if (potentialAnswer < endingTone && endingTone < startingTone)
                {
                    return answer;
                }
                else if (potentialAnswer > endingTone && endingTone > startingTone)
                {
                    return answer;
                }

                var potentialSolution = HctColor.From(hue, chroma, potentialAnswer);
                if (IsCloseToChroma(potentialSolution, chroma))
                {
                    return potentialAnswer;
                }

                double potentialDelta = Math.Abs(potentialSolution.Chroma - chroma);
                double currentDelta = Math.Abs(closestToChroma.Chroma - chroma);
                if (potentialDelta < currentDelta)
                {
                    closestToChroma = potentialSolution;
                    answer = potentialAnswer;
                }
            }
        }

        return answer;
    }

    private static double MainTone(TonalPalette tonalPalette, double maxTone)
    {
        double initialTone = maxTone;
        double endingTone = ForegroundToneCalculation.ForegroundTone(25.0, /* ratio= */ 7.0);
        return FindDesiredChromaByTone(
            tonalPalette.Hue, tonalPalette.Chroma, initialTone, endingTone);
    }

    private static double DimTone(TonalPalette tonalPalette, double maxTone)
    {
        double initialTone = Math.Min(MainTone(tonalPalette, maxTone) - 5.0, maxTone);
        double endingTone = ForegroundToneCalculation.ForegroundTone(25.0, ratio: 4.5);
        return FindDesiredChromaByTone(
            tonalPalette.Hue, tonalPalette.Chroma, initialTone, endingTone);
    }

    private static double ContainerTone(TonalPalette tonalPalette, double maxTone)
    {
        double initialTone = Math.Min(DimTone(tonalPalette, maxTone) - 5.0, maxTone);
        double endingTone = ForegroundToneCalculation.ForegroundTone(0.0, ratio: 7.0);
        return FindDesiredChromaByTone(
            tonalPalette.Hue, tonalPalette.Chroma, initialTone, endingTone);
    }

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
        return double.Clamp(answer, lowerBound, upperBound);
    }

    private static double TMinC(TonalPalette palette) => TMinC(palette, 0, 100);

    private static double TMinC(TonalPalette palette, double lowerBound, double upperBound)
    {
        double answer = FindBestToneForChroma(palette.Hue, palette.Chroma, 0, false);
        return double.Clamp(answer, lowerBound, upperBound);
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

    private static bool IsWatchBlueHue(HctColor sourceColorHct)
    {
        return 250 <= sourceColorHct.Hue && sourceColorHct.Hue <= 270;
    }
    private static double GetExpressiveNeutralHue(HctColor sourceColorHct, Platform platform)
    {
        double[] hueBreakpoints = platform.IsWatch()
            ? [0, 21, 51, 121, 151, 191, 271, 321, 360]
            : [0, 71, 124, 253, 278, 300, 360];
        double[] hueRotations = platform.IsWatch()
            ? [0, 0, 0, 0, 0, 0, 10, 0, 0]
            : [10, 0, 10, 0, 10, 0];
        return DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakpoints, hueRotations);
    }

    private static double GetExpressiveNeutralChroma(HctColor sourceColorHct, bool isDark, Platform platform)
    {
        double neutralHue = GetExpressiveNeutralHue(sourceColorHct, platform);
        if (platform.IsPhone())
            return isDark ? (HctColorCategorization.IsYellow(neutralHue) ? 6 : 14) : 18;
        return 12;
    }

    private static double GetVibrantNeutralHue(HctColor sourceColorHct, Platform platform)
    {
        double[] hueBreakpoints = platform.IsWatch()
            ? [0, 41, 61, 101, 131, 181, 251, 301, 360]
            : [-14, 0, 355, 357, 0, 3, 10, 331, 331];
        double[] hueRotations = platform.IsWatch()
            ? [0, 0, 0, 0, 0, 0, 10, 0, 0]
            : [-14, 10, -14, 10, -14];
        return DynamicScheme.GetRotatedHue(sourceColorHct, hueBreakpoints, hueRotations);
    }

    private static double GetVibrantNeutralChroma(HctColor sourceColorHct, Platform platform)
    {
        return platform.IsPhone()
            ? 28
            : IsWatchBlueHue(sourceColorHct) ? 28 : 20;
    }
}
