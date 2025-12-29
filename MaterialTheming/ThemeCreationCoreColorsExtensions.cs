using M2TWinForms.Themes.Creation;
using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes
{
    partial class Theme
    {
        public static Theme CreateFromCoreColors(ICoreColors coreColors, ThemeMode mode, ContrastLevel contrastLevel, bool normalizeChroma)
        {
            var foregroundTone = GetTone(mode, contrastLevel, false);
            var backgroundTone = GetTone(mode, contrastLevel, true);
            var containerForegroundTone = GetContainerTone(mode, contrastLevel, false);
            var containerBackgroundTone = GetContainerTone(mode, contrastLevel, true);
            var surfaceForegroundTone = GetSurfaceTone(mode, contrastLevel, false);
            var surfaceBackgroundTone = GetSurfaceTone(mode, contrastLevel, true);
            var surfaceVariantForegroundTone = GetSurfaceVariantTone(mode, contrastLevel, false);
            var surfaceVariantBackgroundTone = GetSurfaceVariantTone(mode, contrastLevel, true);
            double surfaceContainerLowestTone = mode == ThemeMode.Dark ? 0 : 100;
            double surfaceContainerLowTone = mode == ThemeMode.Dark ? 6 : 96;
            double surfaceContainerTone = mode == ThemeMode.Dark ? 12 : 92;
            double surfaceContainerHighTone = mode == ThemeMode.Dark ? 18 : 89;
            double surfaceContainerHighestTone = mode == ThemeMode.Dark ? 22 : 86;

            var primaryHct = new HctColor(coreColors.Primary);
            if (normalizeChroma)
                primaryHct.Chroma = TargetChromas.Primary;
            var primaryPalette = new HctTonalPalette(primaryHct);

            var secondaryHct = new HctColor(coreColors.Secondary);
            if (normalizeChroma)
                secondaryHct.Chroma = TargetChromas.Secondary;
            var secondaryPalette = new HctTonalPalette(secondaryHct);

            var tertiaryHct = new HctColor(coreColors.Tertiary);
            if (normalizeChroma)
                tertiaryHct.Chroma = TargetChromas.Tertiary;
            var tertiaryPalette = new HctTonalPalette(tertiaryHct);

            var errorHct = new HctColor(coreColors.Error);
            if (normalizeChroma)
                errorHct.Chroma = TargetChromas.Error;
            var errorPalette = new HctTonalPalette(errorHct);

            var neutralHct = new HctColor(coreColors.Neutral);
            if (normalizeChroma)
                neutralHct.Chroma = TargetChromas.Neutral;
            var neutralPalette = new HctTonalPalette(neutralHct);

            var neutralVariantHct = new HctColor(coreColors.NeutralVariant);
            if (normalizeChroma)
                neutralVariantHct.Chroma = TargetChromas.NeutralVariant;
            var neutralVariantPalette = new HctTonalPalette(neutralVariantHct);

            var colors = new ThemeColors()
            {
                Primary = primaryPalette.GetHctForTone(backgroundTone).GetColor(),
                OnPrimary = primaryPalette.GetHctForTone(foregroundTone).GetColor(),
                PrimaryContainer = primaryPalette.GetHctForTone(containerBackgroundTone).GetColor(),
                OnPrimaryContainer = primaryPalette.GetHctForTone(containerForegroundTone).GetColor(),
                Secondary = secondaryPalette.GetHctForTone(backgroundTone).GetColor(),
                OnSecondary = secondaryPalette.GetHctForTone(foregroundTone).GetColor(),
                SecondaryContainer = secondaryPalette.GetHctForTone(containerBackgroundTone).GetColor(),
                OnSecondaryContainer = secondaryPalette.GetHctForTone(containerForegroundTone).GetColor(),
                Tertiary = tertiaryPalette.GetHctForTone(backgroundTone).GetColor(),
                OnTertiary = tertiaryPalette.GetHctForTone(foregroundTone).GetColor(),
                TertiaryContainer = tertiaryPalette.GetHctForTone(containerBackgroundTone).GetColor(),
                OnTertiaryContainer = tertiaryPalette.GetHctForTone(containerForegroundTone).GetColor(),
                Error = errorPalette.GetHctForTone(backgroundTone).GetColor(),
                OnError = errorPalette.GetHctForTone(foregroundTone).GetColor(),
                ErrorContainer = errorPalette.GetHctForTone(containerBackgroundTone).GetColor(),
                OnErrorContainer = errorPalette.GetHctForTone(containerForegroundTone).GetColor(),
                Surface = neutralPalette.GetHctForTone(surfaceBackgroundTone).GetColor(),
                SurfaceContainer = neutralPalette.GetHctForTone(surfaceContainerTone).GetColor(),
                SurfaceContainerLowest = neutralPalette.GetHctForTone(surfaceContainerLowestTone).GetColor(),
                SurfaceContainerLow = neutralPalette.GetHctForTone(surfaceContainerLowTone).GetColor(),
                SurfaceContainerHigh = neutralPalette.GetHctForTone(surfaceContainerHighTone).GetColor(),
                SurfaceContainerHighest = neutralPalette.GetHctForTone(surfaceContainerHighestTone).GetColor(),
                OnSurface = neutralPalette.GetHctForTone(surfaceForegroundTone).GetColor(),
                OnSurfaceVariant = neutralVariantPalette.GetHctForTone(surfaceVariantForegroundTone).GetColor()
            };

            bool isDark = mode == ThemeMode.Dark;
            return new Theme() 
            { 
                Colors = colors,
                IsDark = isDark,
            };
        }

        private static double GetTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
        {
            var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 80},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 85},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 20},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 45},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 100},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 40},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 100},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 35},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 100}
            };
            return tones[Tuple.Create(mode, contrastLevel, isBackground)];
        }

        private static double GetContainerTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
        {
            var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 35},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 90},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 35},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 95},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 30},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 25}
            };

            return tones[Tuple.Create(mode, contrastLevel, isBackground)];
        }

        private static double GetSurfaceTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
        {
            var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 5},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 3},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 2},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 10},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 99},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 5},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 99},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 3}
            };

            return tones[Tuple.Create(mode, contrastLevel, isBackground)];
        }

        private static double GetSurfaceVariantTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
        {
            var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 80},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 20},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 80},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 30},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 95},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 25},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 20}
            };

            return tones[Tuple.Create(mode, contrastLevel, isBackground)];
        }

    }
}
