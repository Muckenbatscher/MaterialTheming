using MaterialTheming.MaterialDesign.Palettes;
using MaterialTheming.MaterialDesign.Dislike; // Added
using MaterialTheming.MaterialDesign.Temperature; // Added
#if NETFRAMEWORK || NETSTANDARD
using MaterialTheming.System.Double.Extension;
#endif

namespace MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;

internal class ColorSpec2026 : ColorSpec2025
{
    // ----------------------------------------------------------------
    // Palettes
    // ----------------------------------------------------------------

    public override TonalPalette GetPrimaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (variant == Variant.CMF)
        {
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, sourceColorHct.Chroma);
        }
        return base.GetPrimaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    public override TonalPalette GetSecondaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (variant == Variant.CMF)
        {
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, Math.Max(sourceColorHct.Chroma - 32.0, sourceColorHct.Chroma * 0.5));
        }
        return base.GetSecondaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    public override TonalPalette GetTertiaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (variant == Variant.CMF)
        {
            return TonalPalette.FromHct(DislikeAnalyzer.FixIfDisliked(new TemperatureCache(sourceColorHct).GetComplement()));
        }
        return base.GetTertiaryPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    public override TonalPalette GetNeutralPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (variant == Variant.CMF)
        {
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, sourceColorHct.Chroma / 8.0);
        }
        return base.GetNeutralPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    public override TonalPalette GetNeutralVariantPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel)
    {
        if (variant == Variant.CMF)
        {
            return TonalPalette.FromHueAndChroma(sourceColorHct.Hue, (sourceColorHct.Chroma / 8.0) + 4.0);
        }
        return base.GetNeutralVariantPalette(variant, sourceColorHct, isDark, platform, contrastLevel);
    }

    // ----------------------------------------------------------------
    // Surfaces
    // ----------------------------------------------------------------

    public override DynamicColor Surface => CreateSurface().Build();
    private DynamicColorBuilder CreateSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 4.0 : 98.0;
                return base.Surface.Tone(s);
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
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 4.0 : 87.0;
                return base.SurfaceDim.Tone(s);
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 1.0 : 1.7;
                return base.SurfaceDim.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithIsBackground(true);
    }

    public override DynamicColor SurfaceBright => CreateSurfaceBright().Build();
    private DynamicColorBuilder CreateSurfaceBright()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_bright")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 18.0 : 98.0;
                return base.SurfaceBright.Tone(s);
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 1.7 : 1.0;
                return base.SurfaceBright.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithIsBackground(true);
    }

    public override DynamicColor SurfaceContainerLowest => CreateSurfaceContainerLowest().Build();
    private DynamicColorBuilder CreateSurfaceContainerLowest()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_lowest")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 0.0 : 100.0;
                return base.SurfaceContainerLowest.Tone(s);
            })
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
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 6.0 : 96.0;
                return base.SurfaceContainerLow.Tone(s);
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.25;
                return base.SurfaceContainerLow.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithIsBackground(true);
    }

    public override DynamicColor SurfaceContainer => CreateSurfaceContainer().Build();
    private DynamicColorBuilder CreateSurfaceContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 9.0 : 94.0;
                return base.SurfaceContainer.Tone(s);
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.4;
                return base.SurfaceContainer.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithIsBackground(true);
    }

    public override DynamicColor SurfaceContainerHigh => CreateSurfaceContainerHigh().Build();
    private DynamicColorBuilder CreateSurfaceContainerHigh()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_high")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 12.0 : 92.0;
                return base.SurfaceContainerHigh.Tone(s);
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.5;
                return base.SurfaceContainerHigh.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithIsBackground(true);
    }

    public override DynamicColor SurfaceContainerHighest => CreateSurfaceContainerHighest().Build();
    private DynamicColorBuilder CreateSurfaceContainerHighest()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_highest")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 15.0 : 90.0;
                return base.SurfaceContainerHighest.Tone(s);
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.7;
                return base.SurfaceContainerHighest.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithIsBackground(true);
    }

    public override DynamicColor OnSurface => CreateOnSurface().Build();
    private DynamicColorBuilder CreateOnSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.7;
                return base.OnSurface.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? GetContrastCurve(11) : GetContrastCurve(9);
                return base.OnSurface.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnSurfaceVariant => CreateOnSurfaceVariant().Build();
    private DynamicColorBuilder CreateOnSurfaceVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_surface_variant")
            .WithPalette(s => s.NeutralPalette)
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.7;
                return base.OnSurfaceVariant.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? GetContrastCurve(6) : GetContrastCurve(4.5);
                return base.OnSurfaceVariant.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor Outline => CreateOutline().Build();
    private DynamicColorBuilder CreateOutline()
    {
        return DynamicColorBuilder.Create()
            .WithName("outline")
            .WithPalette(s => s.NeutralPalette)
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.7;
                return base.Outline.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(3);
                return base.Outline.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OutlineVariant => CreateOutlineVariant().Build();
    private DynamicColorBuilder CreateOutlineVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("outline_variant")
            .WithPalette(s => s.NeutralPalette)
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.7;
                return base.OutlineVariant.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(1.5);
                return base.OutlineVariant.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor InverseSurface => CreateInverseSurface().Build();
    private DynamicColorBuilder CreateInverseSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 98.0 : 4.0;
                return base.InverseSurface.Tone(s);
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.7;
                return base.InverseSurface.ChromaMultiplier?.Invoke(s) ?? 1.0;
            })
            .WithIsBackground(true);
    }

    public override DynamicColor InverseOnSurface => CreateInverseOnSurface().Build();
    private DynamicColorBuilder CreateInverseOnSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_on_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithBackground(_ => InverseSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(7);
                return base.InverseOnSurface.ContrastCurve?.Invoke(s);
            });
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
                if (s.Variant == Variant.CMF)
                    return s.SourceColor.Chroma <= 12 ? (s.IsDark ? 80.0 : 40.0) : s.SourceColor.Tone;
                return base.Primary.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(4.5);
                return base.Primary.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnPrimary => CreateOnPrimary().Build();
    private DynamicColorBuilder CreateOnPrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(_ => Primary)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(6);
                return base.OnPrimary.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor PrimaryContainer => CreatePrimaryContainer().Build();
    private DynamicColorBuilder CreatePrimaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_container")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                {
                    if (!s.IsDark && s.SourceColor.Chroma <= 12)
                        return 90.0;
                    return s.SourceColor.Tone > 55
                        ? double.Clamp(s.SourceColor.Tone, 61, 90)
                        : double.Clamp(s.SourceColor.Tone, 30, 49);
                }
                return base.PrimaryContainer.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s =>
            {
                if (s.Variant == Variant.CMF)
                    return new ToneDeltaPair(PrimaryContainer, Primary, 5, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther);
                return base.PrimaryContainer.ToneDeltaPair?.Invoke(s);
            })
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.PrimaryContainer.ContrastCurve?.Invoke(s);
            });
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
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(6);
                return base.OnPrimaryContainer.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor PrimaryFixed => CreatePrimaryFixed().Build();
    private DynamicColorBuilder CreatePrimaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_fixed")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                {
                    var tempS = DynamicScheme.From(s, false, 0.0);
                    return PrimaryContainer.GetTone(tempS);
                }
                return base.PrimaryFixed.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.PrimaryFixed.ContrastCurve?.Invoke(s);
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
                if (s.Variant == Variant.CMF)
                    return PrimaryFixed.GetTone(s);
                return base.PrimaryFixedDim.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s =>
            {
                if (s.Variant == Variant.CMF)
                    return new ToneDeltaPair(PrimaryFixedDim, PrimaryFixed, 5, TonePolarity.Darker, ToneDeltaConstraint.Exact);
                return base.PrimaryFixedDim.ToneDeltaPair?.Invoke(s);
            })
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.PrimaryFixedDim.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnPrimaryFixed => CreateOnPrimaryFixed().Build();
    private DynamicColorBuilder CreateOnPrimaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(_ => PrimaryFixedDim)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(7);
                return base.OnPrimaryFixed.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnPrimaryFixedVariant => CreateOnPrimaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnPrimaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed_variant")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(_ => PrimaryFixedDim)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(4.5);
                return base.OnPrimaryFixedVariant.ContrastCurve?.Invoke(s);
            });
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
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? TMinC(s.SecondaryPalette) : TMaxC(s.SecondaryPalette);
                return base.Secondary.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(4.5);
                return base.Secondary.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnSecondary => CreateOnSecondary().Build();
    private DynamicColorBuilder CreateOnSecondary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => Secondary)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(6);
                return base.OnSecondary.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor SecondaryContainer => CreateSecondaryContainer().Build();
    private DynamicColorBuilder CreateSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? TMinC(s.SecondaryPalette, 20, 49) : TMaxC(s.SecondaryPalette, 61, 90);
                return base.SecondaryContainer.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s =>
            {
                if (s.Variant == Variant.CMF)
                    return new ToneDeltaPair(SecondaryContainer, Secondary, 5, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther);
                return base.SecondaryContainer.ToneDeltaPair?.Invoke(s);
            })
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.SecondaryContainer.ContrastCurve?.Invoke(s);
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
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(6);
                return base.OnSecondaryContainer.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor SecondaryFixed => CreateSecondaryFixed().Build();
    private DynamicColorBuilder CreateSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                {
                    var tempS = DynamicScheme.From(s, false, 0.0);
                    return SecondaryContainer.GetTone(tempS);
                }
                return base.SecondaryFixed.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.SecondaryFixed.ContrastCurve?.Invoke(s);
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
                if (s.Variant == Variant.CMF)
                    return SecondaryFixed.GetTone(s);
                return base.SecondaryFixedDim.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s =>
            {
                if (s.Variant == Variant.CMF)
                    return new ToneDeltaPair(SecondaryFixedDim, SecondaryFixed, 5, TonePolarity.Darker, ToneDeltaConstraint.Exact);
                return base.SecondaryFixedDim.ToneDeltaPair?.Invoke(s);
            })
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.SecondaryFixedDim.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnSecondaryFixed => CreateOnSecondaryFixed().Build();
    private DynamicColorBuilder CreateOnSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => SecondaryFixedDim)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(7);
                return base.OnSecondaryFixed.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnSecondaryFixedVariant => CreateOnSecondaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnSecondaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed_variant")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => SecondaryFixedDim)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(4.5);
                return base.OnSecondaryFixedVariant.ContrastCurve?.Invoke(s);
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
                if (s.Variant == Variant.CMF)
                {
                    // Fallback to SourceColor as we don't have list
                    return s.SourceColor.Tone;
                }
                return base.Tertiary.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(4.5);
                return base.Tertiary.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnTertiary => CreateOnTertiary().Build();
    private DynamicColorBuilder CreateOnTertiary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => Tertiary)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(6);
                return base.OnTertiary.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor TertiaryContainer => CreateTertiaryContainer().Build();
    private DynamicColorBuilder CreateTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                {
                    // Fallback to SourceColor as we don't have list
                    var secondarySourceTone = s.SourceColor.Tone;
                    return secondarySourceTone > 55
                        ? double.Clamp(secondarySourceTone, 61, 90)
                        : double.Clamp(secondarySourceTone, 20, 49);
                }
                return base.TertiaryContainer.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s =>
            {
                if (s.Variant == Variant.CMF)
                    return new ToneDeltaPair(TertiaryContainer, Tertiary, 5, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther);
                return base.TertiaryContainer.ToneDeltaPair?.Invoke(s);
            })
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.TertiaryContainer.ContrastCurve?.Invoke(s);
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
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(6);
                return base.OnTertiaryContainer.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor TertiaryFixed => CreateTertiaryFixed().Build();
    private DynamicColorBuilder CreateTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (s.Variant == Variant.CMF)
                {
                    var tempS = DynamicScheme.From(s, false, 0.0);
                    return TertiaryContainer.GetTone(tempS);
                }
                return base.TertiaryFixed.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.TertiaryFixed.ContrastCurve?.Invoke(s);
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
                if (s.Variant == Variant.CMF)
                    return TertiaryFixed.GetTone(s);
                return base.TertiaryFixedDim.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s =>
            {
                if (s.Variant == Variant.CMF)
                    return new ToneDeltaPair(TertiaryFixedDim, TertiaryFixed, 5, TonePolarity.Darker, ToneDeltaConstraint.Exact);
                return base.TertiaryFixedDim.ToneDeltaPair?.Invoke(s);
            })
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.TertiaryFixedDim.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnTertiaryFixed => CreateOnTertiaryFixed().Build();
    private DynamicColorBuilder CreateOnTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => TertiaryFixedDim)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(7);
                return base.OnTertiaryFixed.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnTertiaryFixedVariant => CreateOnTertiaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnTertiaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed_variant")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => TertiaryFixedDim)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(4.5);
                return base.OnTertiaryFixedVariant.ContrastCurve?.Invoke(s);
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
                if (s.Variant == Variant.CMF)
                    return TMaxC(s.ErrorPalette);
                return base.Error.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(4.5);
                return base.Error.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnError => CreateOnError().Build();
    private DynamicColorBuilder CreateOnError()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error")
            .WithPalette(s => s.ErrorPalette)
            .WithBackground(_ => Error)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(6);
                return base.OnError.ContrastCurve?.Invoke(s);
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
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? TMinC(s.ErrorPalette) : TMaxC(s.ErrorPalette);
                return base.ErrorContainer.Tone(s);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s =>
            {
                if (s.Variant == Variant.CMF)
                    return new ToneDeltaPair(ErrorContainer, Error, 5, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther);
                return base.ErrorContainer.ToneDeltaPair?.Invoke(s);
            })
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null;
                return base.ErrorContainer.ContrastCurve?.Invoke(s);
            });
    }

    public override DynamicColor OnErrorContainer => CreateOnErrorContainer().Build();
    private DynamicColorBuilder CreateOnErrorContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error_container")
            .WithPalette(s => s.ErrorPalette)
            .WithBackground(_ => ErrorContainer)
            .WithContrastCurve(s =>
            {
                if (s.Variant == Variant.CMF)
                    return GetContrastCurve(6);
                return base.OnErrorContainer.ContrastCurve?.Invoke(s);
            });
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
}
