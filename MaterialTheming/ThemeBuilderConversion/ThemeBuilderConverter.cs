using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeBuilderConversion.SerializationModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeBuilderConversion
{
    internal class ThemeBuilderConverter
    {
        public ThemeColors ConvertFromThemeBuilder(Scheme scheme)
        {
            var themeColors = new ThemeColors()
            {
                Primary = ColorTranslator.FromHtml(scheme.Primary),
                OnPrimary = ColorTranslator.FromHtml(scheme.OnPrimary),
                PrimaryContainer = ColorTranslator.FromHtml(scheme.PrimaryContainer),
                OnPrimaryContainer = ColorTranslator.FromHtml(scheme.OnPrimaryContainer),

                Secondary = ColorTranslator.FromHtml(scheme.Secondary),
                OnSecondary = ColorTranslator.FromHtml(scheme.OnSecondary),
                SecondaryContainer = ColorTranslator.FromHtml(scheme.SecondaryContainer),
                OnSecondaryContainer = ColorTranslator.FromHtml(scheme.OnSecondaryContainer),

                Tertiary = ColorTranslator.FromHtml(scheme.Tertiary),
                OnTertiary = ColorTranslator.FromHtml(scheme.OnTertiary),
                TertiaryContainer = ColorTranslator.FromHtml(scheme.TertiaryContainer),
                OnTertiaryContainer = ColorTranslator.FromHtml(scheme.OnTertiaryContainer),

                Error = ColorTranslator.FromHtml(scheme.Error),
                OnError = ColorTranslator.FromHtml(scheme.OnError),
                ErrorContainer = ColorTranslator.FromHtml(scheme.ErrorContainer),
                OnErrorContainer = ColorTranslator.FromHtml(scheme.OnErrorContainer),

                Surface = ColorTranslator.FromHtml(scheme.Surface),
                SurfaceContainer = ColorTranslator.FromHtml(scheme.SurfaceContainer),
                SurfaceContainerLowest = ColorTranslator.FromHtml(scheme.SurfaceContainerLowest),
                SurfaceContainerLow = ColorTranslator.FromHtml(scheme.SurfaceContainerLow),
                SurfaceContainerHigh = ColorTranslator.FromHtml(scheme.SurfaceContainerHigh),
                SurfaceContainerHighest = ColorTranslator.FromHtml(scheme.SurfaceContainerHighest),
                OnSurface = ColorTranslator.FromHtml(scheme.OnSurface),
                OnSurfaceVariant = ColorTranslator.FromHtml(scheme.OnSurfaceVariant)
            };
            return themeColors;
        }
    }
}
