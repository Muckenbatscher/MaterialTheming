using M2TWinForms.Themes.Creation;
using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeProviders
{
    internal class DefaultLightThemeProvider : DefaultThemeProvider
    {
        protected override bool IsDark => true;

        protected override IThemeColors CreateThemeColors()
        {
            return new ThemeColors
            {
                Primary = ColorTranslator.FromHtml("#6D5E0F"),
                OnPrimary = ColorTranslator.FromHtml("#FFFFFF"),
                PrimaryContainer = ColorTranslator.FromHtml("#F8E288"),
                OnPrimaryContainer = ColorTranslator.FromHtml("#534600"),
                Secondary = ColorTranslator.FromHtml("#665E40"),
                OnSecondary = ColorTranslator.FromHtml("#FFFFFF"),
                SecondaryContainer = ColorTranslator.FromHtml("#EEE2BC"),
                OnSecondaryContainer = ColorTranslator.FromHtml("#4D472A"),
                Tertiary = ColorTranslator.FromHtml("#43664F"),
                OnTertiary = ColorTranslator.FromHtml("#FFFFFF"),
                TertiaryContainer = ColorTranslator.FromHtml("#C5ECCF"),
                OnTertiaryContainer = ColorTranslator.FromHtml("#2B4E38"),
                Error = ColorTranslator.FromHtml("#BA1A1A"),
                OnError = ColorTranslator.FromHtml("#FFFFFF"),
                ErrorContainer = ColorTranslator.FromHtml("#FFDAD6"),
                OnErrorContainer = ColorTranslator.FromHtml("#93000A"),
                Surface = ColorTranslator.FromHtml("#FFF9ED"),
                SurfaceContainer = ColorTranslator.FromHtml("#F4EDE3"),
                SurfaceContainerLowest = ColorTranslator.FromHtml("#FFFFFF"),
                SurfaceContainerLow = ColorTranslator.FromHtml("#FAF3E5"),
                SurfaceContainerHigh = ColorTranslator.FromHtml("#EEE8DA"),
                SurfaceContainerHighest = ColorTranslator.FromHtml("#E8E2D4"),
                OnSurface = ColorTranslator.FromHtml("#1E1C13"),
                OnSurfaceVariant = ColorTranslator.FromHtml("#4B4739"),
            };
        }
    }
}
