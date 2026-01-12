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
    // Surfaces
    // ----------------------------------------------------------------

    public virtual DynamicColor Background => CreateBackground().Build();
    private DynamicColorBuilder CreateBackground()
    {
        return DynamicColorBuilder.Create()
            .WithName("background")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 6.0 : 98.0)
            .WithIsBackground(true);
    }

    public virtual DynamicColor OnBackground => CreateOnBackground().Build();
    private DynamicColorBuilder CreateOnBackground()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_background")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 90.0 : 10.0)
            .WithBackground(_ => Background)
            .WithContrastCurve(s => new ContrastCurve(3.0, 3.0, 4.5, 7.0));
    }

    public virtual DynamicColor Surface => CreateSurface().Build();
    private DynamicColorBuilder CreateSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 6.0 : 98.0)
            .WithIsBackground(true);
    }

    public virtual DynamicColor SurfaceDim => CreateSurfaceDim().Build();
    private DynamicColorBuilder CreateSurfaceDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_dim")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 6.0 : new ContrastCurve(87.0, 87.0, 80.0, 75.0).Get(s.ContrastLevel))
            .WithIsBackground(true);
    }

    public virtual DynamicColor SurfaceBright => CreateSurfaceBright().Build();
    private DynamicColorBuilder CreateSurfaceBright()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_bright")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? new ContrastCurve(24.0, 24.0, 29.0, 34.0).Get(s.ContrastLevel) : 98.0)
            .WithIsBackground(true);
    }

    public virtual DynamicColor SurfaceContainerLowest => CreateSurfaceContainerLowest().Build();
    private DynamicColorBuilder CreateSurfaceContainerLowest()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_lowest")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? new ContrastCurve(4.0, 4.0, 2.0, 0.0).Get(s.ContrastLevel) : 100.0)
            .WithIsBackground(true);
    }

    public virtual DynamicColor SurfaceContainerLow => CreateSurfaceContainerLow().Build();
    private DynamicColorBuilder CreateSurfaceContainerLow()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_low")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark
                ? new ContrastCurve(10.0, 10.0, 11.0, 12.0).Get(s.ContrastLevel)
                : new ContrastCurve(96.0, 96.0, 96.0, 95.0).Get(s.ContrastLevel))
            .WithIsBackground(true);
    }

    public virtual DynamicColor SurfaceContainer => CreateSurfaceContainer().Build();
    private DynamicColorBuilder CreateSurfaceContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark
                ? new ContrastCurve(12.0, 12.0, 16.0, 20.0).Get(s.ContrastLevel)
                : new ContrastCurve(94.0, 94.0, 92.0, 90.0).Get(s.ContrastLevel))
            .WithIsBackground(true);
    }

    public virtual DynamicColor SurfaceContainerHigh => CreateSurfaceContainerHigh().Build();
    private DynamicColorBuilder CreateSurfaceContainerHigh()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_high")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark
                ? new ContrastCurve(17.0, 17.0, 21.0, 25.0).Get(s.ContrastLevel)
                : new ContrastCurve(92.0, 92.0, 88.0, 85.0).Get(s.ContrastLevel))
            .WithIsBackground(true);
    }

    public virtual DynamicColor SurfaceContainerHighest => CreateSurfaceContainerHighest().Build();
    private DynamicColorBuilder CreateSurfaceContainerHighest()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_container_highest")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark
                ? new ContrastCurve(22.0, 22.0, 26.0, 30.0).Get(s.ContrastLevel)
                : new ContrastCurve(90.0, 90.0, 84.0, 80.0).Get(s.ContrastLevel))
            .WithIsBackground(true);
    }

    public virtual DynamicColor OnSurface => CreateOnSurface().Build();
    private DynamicColorBuilder CreateOnSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 90.0 : 10.0)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor SurfaceVariant => CreateSurfaceVariant().Build();
    private DynamicColorBuilder CreateSurfaceVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_variant")
            .WithPalette(s => s.NeutralVariantPalette)
            .WithTone(s => s.IsDark ? 30.0 : 90.0)
            .WithIsBackground(true);
    }

    public virtual DynamicColor OnSurfaceVariant => CreateOnSurfaceVariant().Build();
    private DynamicColorBuilder CreateOnSurfaceVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_surface_variant")
            .WithPalette(s => s.NeutralVariantPalette)
            .WithTone(s => s.IsDark ? 80.0 : 30.0)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 11.0));
    }

    public virtual DynamicColor InverseSurface => CreateInverseSurface().Build();
    private DynamicColorBuilder CreateInverseSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 90.0 : 20.0)
            .WithIsBackground(true);
    }

    public virtual DynamicColor InverseOnSurface => CreateInverseOnSurface().Build();
    private DynamicColorBuilder CreateInverseOnSurface()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_on_surface")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => s.IsDark ? 20.0 : 95.0)
            .WithBackground(_ => InverseSurface)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor Outline => CreateOutline().Build();
    private DynamicColorBuilder CreateOutline()
    {
        return DynamicColorBuilder.Create()
            .WithName("outline")
            .WithPalette(s => s.NeutralVariantPalette)
            .WithTone(s => s.IsDark ? 60.0 : 50.0)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.5, 3.0, 4.5, 7.0));
    }

    public virtual DynamicColor OutlineVariant => CreateOutlineVariant().Build();
    private DynamicColorBuilder CreateOutlineVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("outline_variant")
            .WithPalette(s => s.NeutralVariantPalette)
            .WithTone(s => s.IsDark ? 30.0 : 80.0)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5));
    }

    public virtual DynamicColor Shadow => CreateShadow().Build();
    private DynamicColorBuilder CreateShadow()
    {
        return DynamicColorBuilder.Create()
            .WithName("shadow")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => 0.0);
    }

    public virtual DynamicColor Scrim => CreateScrim().Build();
    private DynamicColorBuilder CreateScrim()
    {
        return DynamicColorBuilder.Create()
            .WithName("scrim")
            .WithPalette(s => s.NeutralPalette)
            .WithTone(s => 0.0);
    }

    public virtual DynamicColor SurfaceTint => CreateSurfaceTint().Build();
    private DynamicColorBuilder CreateSurfaceTint()
    {
        return DynamicColorBuilder.Create()
            .WithName("surface_tint")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => s.IsDark ? 80.0 : 40.0)
            .WithIsBackground(true);
    }

    // ----------------------------------------------------------------
    // Primaries
    // ----------------------------------------------------------------

    public virtual DynamicColor Primary => CreatePrimary().Build();
    private DynamicColorBuilder CreatePrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => IsMonochrome(s) ? (s.IsDark ? 100.0 : 0.0) : (s.IsDark ? 80.0 : 40.0))
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 7.0))
            .WithToneDeltaPair(s => new ToneDeltaPair(PrimaryContainer, Primary, 10.0, TonePolarity.Nearer, false));
    }

    public virtual DynamicColor? PrimaryDim => null;

    public virtual DynamicColor OnPrimary => CreateOnPrimary().Build();
    private DynamicColorBuilder CreateOnPrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (IsMonochrome(s))
                    return s.IsDark ? 10.0 : 90.0;
                return s.IsDark ? 20.0 : 100.0;
            })
            .WithBackground(_ => Primary)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor PrimaryContainer => CreatePrimaryContainer().Build();
    private DynamicColorBuilder CreatePrimaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_container")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (IsFidelity(s))
                    return s.SourceColor.Tone;
                if (IsMonochrome(s))
                    return s.IsDark ? 85.0 : 25.0;
                return s.IsDark ? 30.0 : 90.0;
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(PrimaryContainer, Primary, 10.0, TonePolarity.Nearer, false));
    }

    public virtual DynamicColor OnPrimaryContainer => CreateOnPrimaryContainer().Build();
    private DynamicColorBuilder CreateOnPrimaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_container")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s =>
            {
                if (IsFidelity(s))
                {
                    return ForegroundToneCalculation.ForegroundTone(PrimaryContainer.Tone(s), 4.5);
                }
                if (IsMonochrome(s))
                    return s.IsDark ? 0.0 : 100.0;
                return s.IsDark ? 90.0 : 30.0;
            })
            .WithBackground(_ => PrimaryContainer)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 11.0));
    }

    public virtual DynamicColor InversePrimary => CreateInversePrimary().Build();
    private DynamicColorBuilder CreateInversePrimary()
    {
        return DynamicColorBuilder.Create()
            .WithName("inverse_primary")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => s.IsDark ? 40.0 : 80.0)
            .WithBackground(_ => InverseSurface)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 7.0));
    }

    // ----------------------------------------------------------------
    // Secondaries
    // ----------------------------------------------------------------

    public virtual DynamicColor Secondary => CreateSecondary().Build();
    private DynamicColorBuilder CreateSecondary()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => s.IsDark ? 80 : 40)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 7.0))
            .WithToneDeltaPair(s => new ToneDeltaPair(SecondaryContainer, Secondary, 10.0, TonePolarity.Nearer, false));
    }

    public virtual DynamicColor? SecondaryDim => null;

    public virtual DynamicColor OnSecondary => CreateOnSecondary().Build();
    private DynamicColorBuilder CreateOnSecondary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (IsMonochrome(s))
                    return s.IsDark ? 10.0 : 100.0;
                return s.IsDark ? 20.0 : 100.0;
            })
            .WithBackground(_ => Secondary)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor SecondaryContainer => CreateSecondaryContainer().Build();
    private DynamicColorBuilder CreateSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                double initialTone = s.IsDark ? 30.0 : 90.0;
                if (IsMonochrome(s))
                    return s.IsDark ? 30.0 : 85.0;
                if (!IsFidelity(s))
                    return initialTone;

                return FindDesiredChromaByTone(
                    s.SecondaryPalette.Hue,
                    s.SecondaryPalette.Chroma,
                    initialTone,
                    !s.IsDark);
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(SecondaryContainer, Secondary, 10.0, TonePolarity.Nearer, false));
    }

    public virtual DynamicColor OnSecondaryContainer => CreateOnSecondaryContainer().Build();
    private DynamicColorBuilder CreateOnSecondaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_container")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s =>
            {
                if (IsMonochrome(s))
                    return s.IsDark ? 90.0 : 10.0;
                if (!IsFidelity(s))
                    return s.IsDark ? 90.0 : 30.0;
                return ForegroundToneCalculation.ForegroundTone(SecondaryContainer.Tone(s), 4.5);
            })
            .WithBackground(_ => SecondaryContainer)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 11.0));
    }

    // ----------------------------------------------------------------
    // Tertiaries
    // ----------------------------------------------------------------

    public virtual DynamicColor Tertiary => CreateTertiary().Build();
    private DynamicColorBuilder CreateTertiary()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (IsMonochrome(s))
                    return s.IsDark ? 90.0 : 25.0;
                return s.IsDark ? 80.0 : 40.0;
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 7.0))
            .WithToneDeltaPair(s => new ToneDeltaPair(TertiaryContainer, Tertiary, 10.0, TonePolarity.Nearer, false));
    }

    public virtual DynamicColor? TertiaryDim => null;

    public virtual DynamicColor OnTertiary => CreateOnTertiary().Build();
    private DynamicColorBuilder CreateOnTertiary()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (IsMonochrome(s))
                    return s.IsDark ? 10.0 : 90.0;
                return s.IsDark ? 20.0 : 100.0;
            })
            .WithBackground(_ => Tertiary)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor TertiaryContainer => CreateTertiaryContainer().Build();
    private DynamicColorBuilder CreateTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (IsMonochrome(s))
                    return s.IsDark ? 60.0 : 49.0;
                if (!IsFidelity(s))
                    return s.IsDark ? 30.0 : 90.0;

                var proposedHct = s.TertiaryPalette.GetHct(s.SourceColor.Tone);
                return DislikeAnalyzer.FixIfDisliked(proposedHct).Tone;
            })
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(TertiaryContainer, Tertiary, 10.0, TonePolarity.Nearer, false));
    }

    public virtual DynamicColor OnTertiaryContainer => CreateOnTertiaryContainer().Build();
    private DynamicColorBuilder CreateOnTertiaryContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_container")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s =>
            {
                if (IsMonochrome(s))
                    return s.IsDark ? 0.0 : 100.0;
                if (!IsFidelity(s))
                    return s.IsDark ? 90.0 : 30.0;
                return ForegroundToneCalculation.ForegroundTone(TertiaryContainer.Tone(s), 4.5);
            })
            .WithBackground(_ => TertiaryContainer)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 11.0));
    }

    // ----------------------------------------------------------------
    // Errors
    // ----------------------------------------------------------------

    public virtual DynamicColor Error => CreateError().Build();
    private DynamicColorBuilder CreateError()
    {
        return DynamicColorBuilder.Create()
            .WithName("error")
            .WithPalette(s => s.ErrorPalette)
            .WithTone(s => s.IsDark ? 80.0 : 40.0)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 7.0))
            .WithToneDeltaPair(s => new ToneDeltaPair(ErrorContainer, Error, 10.0, TonePolarity.Nearer, false));
    }

    public virtual DynamicColor? ErrorDim => null;

    public virtual DynamicColor OnError => CreateOnError().Build();
    private DynamicColorBuilder CreateOnError()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error")
            .WithPalette(s => s.ErrorPalette)
            .WithTone(s => s.IsDark ? 20.0 : 100.0)
            .WithBackground(_ => Error)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor ErrorContainer => CreateErrorContainer().Build();
    private DynamicColorBuilder CreateErrorContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("error_container")
            .WithPalette(s => s.ErrorPalette)
            .WithTone(s => s.IsDark ? 30.0 : 90.0)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(ErrorContainer, Error, 10.0, TonePolarity.Nearer, false));
    }

    public virtual DynamicColor OnErrorContainer => CreateOnErrorContainer().Build();
    private DynamicColorBuilder CreateOnErrorContainer()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_error_container")
            .WithPalette(s => s.ErrorPalette)
            .WithTone(s =>
            {
                if (IsMonochrome(s))
                    return s.IsDark ? 90.0 : 10.0;
                return s.IsDark ? 90.0 : 30.0;
            })
            .WithBackground(_ => ErrorContainer)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 11.0));
    }

    // ----------------------------------------------------------------
    // Primary Fixed
    // ----------------------------------------------------------------

    public virtual DynamicColor PrimaryFixed => CreatePrimaryFixed().Build();
    private DynamicColorBuilder CreatePrimaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_fixed")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => IsMonochrome(s) ? 40.0 : 90.0)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(PrimaryFixed, PrimaryFixedDim, 10.0, TonePolarity.Lighter, true));
    }

    public virtual DynamicColor PrimaryFixedDim => CreatePrimaryFixedDim().Build();
    private DynamicColorBuilder CreatePrimaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("primary_fixed_dim")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => IsMonochrome(s) ? 30.0 : 80.0)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(PrimaryFixed, PrimaryFixedDim, 10.0, TonePolarity.Lighter, true));
    }

    public virtual DynamicColor OnPrimaryFixed => CreateOnPrimaryFixed().Build();
    private DynamicColorBuilder CreateOnPrimaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => IsMonochrome(s) ? 100.0 : 10.0)
            .WithBackground(_ => PrimaryFixedDim)
            .WithSecondBackground(_ => PrimaryFixed)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor OnPrimaryFixedVariant => CreateOnPrimaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnPrimaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_primary_fixed_variant")
            .WithPalette(s => s.PrimaryPalette)
            .WithTone(s => IsMonochrome(s) ? 90.0 : 30.0)
            .WithBackground(_ => PrimaryFixedDim)
            .WithSecondBackground(_ => PrimaryFixed)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 11.0));
    }

    // ----------------------------------------------------------------
    // Secondary Fixed
    // ----------------------------------------------------------------

    public virtual DynamicColor SecondaryFixed => CreateSecondaryFixed().Build();
    private DynamicColorBuilder CreateSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => IsMonochrome(s) ? 80.0 : 90.0)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(SecondaryFixed, SecondaryFixedDim, 10.0, TonePolarity.Lighter, true));
    }

    public virtual DynamicColor SecondaryFixedDim => CreateSecondaryFixedDim().Build();
    private DynamicColorBuilder CreateSecondaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("secondary_fixed_dim")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => IsMonochrome(s) ? 70.0 : 80.0)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(SecondaryFixed, SecondaryFixedDim, 10.0, TonePolarity.Lighter, true));
    }

    public virtual DynamicColor OnSecondaryFixed => CreateOnSecondaryFixed().Build();
    private DynamicColorBuilder CreateOnSecondaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => 10.0)
            .WithBackground(_ => SecondaryFixedDim)
            .WithSecondBackground(_ => SecondaryFixed)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor OnSecondaryFixedVariant => CreateOnSecondaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnSecondaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_secondary_fixed_variant")
            .WithPalette(s => s.SecondaryPalette)
            .WithTone(s => IsMonochrome(s) ? 25.0 : 30.0)
            .WithBackground(_ => SecondaryFixedDim)
            .WithSecondBackground(_ => SecondaryFixed)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 11.0));
    }

    // ----------------------------------------------------------------
    // Tertiary Fixed
    // ----------------------------------------------------------------

    public virtual DynamicColor TertiaryFixed => CreateTertiaryFixed().Build();
    private DynamicColorBuilder CreateTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => IsMonochrome(s) ? 40.0 : 90.0)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(TertiaryFixed, TertiaryFixedDim, 10.0, TonePolarity.Lighter, true));
    }

    public virtual DynamicColor TertiaryFixedDim => CreateTertiaryFixedDim().Build();
    private DynamicColorBuilder CreateTertiaryFixedDim()
    {
        return DynamicColorBuilder.Create()
            .WithName("tertiary_fixed_dim")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => IsMonochrome(s) ? 30.0 : 80.0)
            .WithIsBackground(true)
            .WithBackground(HighestSurface)
            .WithContrastCurve(s => new ContrastCurve(1.0, 1.0, 3.0, 4.5))
            .WithToneDeltaPair(s => new ToneDeltaPair(TertiaryFixed, TertiaryFixedDim, 10.0, TonePolarity.Lighter, true));
    }

    public virtual DynamicColor OnTertiaryFixed => CreateOnTertiaryFixed().Build();
    private DynamicColorBuilder CreateOnTertiaryFixed()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => IsMonochrome(s) ? 100.0 : 10.0)
            .WithBackground(_ => TertiaryFixedDim)
            .WithSecondBackground(_ => TertiaryFixed)
            .WithContrastCurve(s => new ContrastCurve(4.5, 7.0, 11.0, 21.0));
    }

    public virtual DynamicColor OnTertiaryFixedVariant => CreateOnTertiaryFixedVariant().Build();
    private DynamicColorBuilder CreateOnTertiaryFixedVariant()
    {
        return DynamicColorBuilder.Create()
            .WithName("on_tertiary_fixed_variant")
            .WithPalette(s => s.TertiaryPalette)
            .WithTone(s => IsMonochrome(s) ? 90.0 : 30.0)
            .WithBackground(_ => TertiaryFixedDim)
            .WithSecondBackground(_ => TertiaryFixed)
            .WithContrastCurve(s => new ContrastCurve(3.0, 4.5, 7.0, 11.0));
    }

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

                if (chromaPeak > potentialSolution.Chroma)
                    break;
                if (Math.Abs(potentialSolution.Chroma - chroma) < 0.4)
                    break;

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
                    if (expansionDir > 0)
                        fTone = 60;
                    else
                        fTone = 49;
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

            if (bg == null || curve == null)
                return answer;

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

            if (color.SecondBackground == null)
                return answer;

            DynamicColor? bg2 = color.SecondBackground(scheme);
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

            List<double> availables = new();
            if (lightOption != -1)
                availables.Add(lightOption);
            if (darkOption != -1)
                availables.Add(darkOption);

            bool prefersLight = ForegroundToneCalculation.TonePrefersLightForeground(bgTone1) ||
                                ForegroundToneCalculation.TonePrefersLightForeground(bgTone2);

            if (prefersLight)
                return lightOption == -1 ? 100 : lightOption;
            if (availables.Count == 1)
                return availables[0];
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
