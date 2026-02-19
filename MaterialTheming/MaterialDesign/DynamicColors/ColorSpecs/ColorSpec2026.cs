using MaterialTheming.MaterialDesign.Palettes;
#if NETFRAMEWORK || NETSTANDARD
using MaterialTheming.System.Double.Extension;
using System.Diagnostics.CodeAnalysis;
#endif

namespace MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;

internal class ColorSpec2026 : ColorSpec2025
{
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
                return 0.0; // undefined usecase
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
                return 0.0; // undefined use case
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 1.0 : 1.7;
                return 0.0; // undefined use case
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
                return 0.0; // undefined use case
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return s.IsDark ? 1.7 : 1.0;
                return 0.0; // undefined use case
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
                return 0.0; // undefined use case
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
                return 0.0; // undefined use case
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.25;
                return 0.0; // undefined use case
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
                return 0.0; // undefined use case
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.4;
                return 0.0; // undefined use case
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
                return 0.0; // undefined use case
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.5;
                return 0.0; // undefined use case
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
                return 0.0; // undefined use case
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.7;
                return 0.0; // undefined use case
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
                return 0.0; // undefined use case
            })
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => s.IsDark ? GetContrastCurve(11) : GetContrastCurve(9));
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
                return 0.0; // undefined use case
            })
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => s.IsDark ? GetContrastCurve(6) : GetContrastCurve(4.5));
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
                return 0.0; // undefined use case
            })
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => GetContrastCurve(3));
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
                return 0.0; // undefined use case
            })
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => GetContrastCurve(1.5));
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
                return 0.0; // undefined use case
            })
            .WithChromaMultiplier(s =>
            {
                if (s.Variant == Variant.CMF)
                    return 1.7;
                return 0.0; // undefined use case
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
            .WithContrastCurve(s => GetContrastCurve(7));
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
                return 0.0; // undefined use case
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => GetContrastCurve(4.5));
    }

    public override DynamicColor OnPrimary => CreateOnPrimary().Build();
    private DynamicColorBuilder CreateOnPrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(_ => Primary)
            .WithContrastCurve(s => GetContrastCurve(6));
    }

    public override DynamicColor PrimaryContainer => CreatePrimaryContainer().Build();
    private DynamicColorBuilder CreatePrimaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_container")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (!s.IsDark && s.SourceColor.Chroma <= 12)
                    return 90.0;
                return s.SourceColor.Tone > 55
                    ? double.Clamp(s.SourceColor.Tone, 61, 90)
                    : double.Clamp(s.SourceColor.Tone, 30, 49);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s => new ToneDeltaPair(PrimaryContainer, Primary, 5, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther))
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor OnPrimaryContainer => CreateOnPrimaryContainer().Build();
    private DynamicColorBuilder CreateOnPrimaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_container")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(_ => PrimaryContainer)
            .WithContrastCurve(s => GetContrastCurve(6));
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
                return 0.0; // undefined use case
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
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
                return 0.0; // undefined use case
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s => new ToneDeltaPair(PrimaryFixedDim, PrimaryFixed, 5, TonePolarity.Darker, ToneDeltaConstraint.Exact))
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor OnPrimaryFixed => CreateOnPrimaryFixed().Build();
    private DynamicColorBuilder CreateOnPrimaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(_ => PrimaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(7));
    }

    public override DynamicColor OnPrimaryFixedVariant => CreateOnPrimaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnPrimaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed_variant")
            .WithPalette(s => s.PrimaryPalette)
            .WithBackground(_ => PrimaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(4.5));
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
                return s.IsDark
                    ? TMinC(s.SecondaryPalette)
                    : TMaxC(s.SecondaryPalette);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => GetContrastCurve(4.5));
    }

    public override DynamicColor OnSecondary => CreateOnSecondary().Build();
    private DynamicColorBuilder CreateOnSecondary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => Secondary)
            .WithContrastCurve(s => GetContrastCurve(6));
    }

    public override DynamicColor SecondaryContainer => CreateSecondaryContainer().Build();
    private DynamicColorBuilder CreateSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                return s.IsDark
                    ? TMinC(s.SecondaryPalette, 20, 49)
                    : TMaxC(s.SecondaryPalette, 61, 90);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s => new ToneDeltaPair(SecondaryContainer, Secondary, 5, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther))
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor OnSecondaryContainer => CreateOnSecondaryContainer().Build();
    private DynamicColorBuilder CreateOnSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => SecondaryContainer)
            .WithContrastCurve(s => GetContrastCurve(6));
    }

    public override DynamicColor SecondaryFixed => CreateSecondaryFixed().Build();
    private DynamicColorBuilder CreateSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                var tempS = DynamicScheme.From(s, false, 0.0);
                return SecondaryContainer.GetTone(tempS);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor SecondaryFixedDim => CreateSecondaryFixedDim().Build();
    private DynamicColorBuilder CreateSecondaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_fixed_dim")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => SecondaryFixed.GetTone(s))
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(_ => new ToneDeltaPair(SecondaryFixedDim, SecondaryFixed, 5, TonePolarity.Darker, ToneDeltaConstraint.Exact))
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor OnSecondaryFixed => CreateOnSecondaryFixed().Build();
    private DynamicColorBuilder CreateOnSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithBackground(_ => SecondaryFixedDim)
            .WithContrastCurve(_ => GetContrastCurve(7));
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
                var sourceColorToUse = s.SecondarySourceColor is not null
                    ? s.SecondarySourceColor
                    : s.SourceColor;
                return sourceColorToUse.Tone;
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => GetContrastCurve(4.5));
    }

    public override DynamicColor OnTertiary => CreateOnTertiary().Build();
    private DynamicColorBuilder CreateOnTertiary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => Tertiary)
            .WithContrastCurve(s => GetContrastCurve(6));
    }

    public override DynamicColor TertiaryContainer => CreateTertiaryContainer().Build();
    private DynamicColorBuilder CreateTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                var sourceColorToUse = s.SecondarySourceColor is not null
                   ? s.SecondarySourceColor
                   : s.SourceColor;
                var sourceToneToUse = sourceColorToUse.Tone;
                return sourceToneToUse > 55
                    ? double.Clamp(sourceToneToUse, 61, 90)
                    : double.Clamp(sourceToneToUse, 20, 49);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s => new ToneDeltaPair(TertiaryContainer, Tertiary, 5, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther))
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor OnTertiaryContainer => CreateOnTertiaryContainer().Build();
    private DynamicColorBuilder CreateOnTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => TertiaryContainer)
            .WithContrastCurve(s => GetContrastCurve(6));
    }

    public override DynamicColor TertiaryFixed => CreateTertiaryFixed().Build();
    private DynamicColorBuilder CreateTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                var tempS = DynamicScheme.From(s, false, 0.0);
                return TertiaryContainer.GetTone(tempS);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor TertiaryFixedDim => CreateTertiaryFixedDim().Build();
    private DynamicColorBuilder CreateTertiaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_fixed_dim")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => TertiaryFixed.GetTone(s))
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s => new ToneDeltaPair(TertiaryFixedDim, TertiaryFixed, 5, TonePolarity.Darker, ToneDeltaConstraint.Exact))
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor OnTertiaryFixed => CreateOnTertiaryFixed().Build();
    private DynamicColorBuilder CreateOnTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => TertiaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(7));
    }

    public override DynamicColor OnTertiaryFixedVariant => CreateOnTertiaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnTertiaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed_variant")
            .WithPalette(s => s.TertiaryPalette)
            .WithBackground(_ => TertiaryFixedDim)
            .WithContrastCurve(s => GetContrastCurve(4.5));
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
            .WithTone(s => TMaxC(s.ErrorPalette))
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => GetContrastCurve(4.5));
    }

    public override DynamicColor OnError => CreateOnError().Build();
    private DynamicColorBuilder CreateOnError()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error")
            .WithPalette(s => s.ErrorPalette)
            .WithBackground(_ => Error)
            .WithContrastCurve(s => GetContrastCurve(6));
    }

    public override DynamicColor ErrorContainer => CreateErrorContainer().Build();
    private DynamicColorBuilder CreateErrorContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("error_container")
            .WithPalette(s => s.ErrorPalette)
            .WithTone(s =>
            {
                return s.IsDark
                    ? TMinC(s.ErrorPalette)
                    : TMaxC(s.ErrorPalette);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithToneDeltaPair(s => new ToneDeltaPair(ErrorContainer, Error, 5, TonePolarity.RelativeLighter, ToneDeltaConstraint.Farther))
            .WithContrastCurve(s => s.ContrastLevel > 0 ? GetContrastCurve(1.5) : null);
    }

    public override DynamicColor OnErrorContainer => CreateOnErrorContainer().Build();
    private DynamicColorBuilder CreateOnErrorContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error_container")
            .WithPalette(s => s.ErrorPalette)
            .WithBackground(_ => ErrorContainer)
            .WithContrastCurve(s => GetContrastCurve(6));
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
