using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.Creation
{
    public interface IThemeColors
    {
        public Color Primary { get; }
        public Color OnPrimary { get; }
        public Color PrimaryContainer { get; }
        public Color OnPrimaryContainer { get; }
        public Color Secondary { get; }
        public Color OnSecondary { get; }
        public Color SecondaryContainer { get; }
        public Color OnSecondaryContainer { get; }
        public Color Tertiary { get; }
        public Color OnTertiary { get; }
        public Color TertiaryContainer { get; }
        public Color OnTertiaryContainer { get; }
        public Color Error { get; }
        public Color OnError { get; }
        public Color ErrorContainer { get; }
        public Color OnErrorContainer { get; }
        public Color Surface { get; }
        public Color SurfaceContainer { get; }
        public Color SurfaceContainerLowest { get; }
        public Color SurfaceContainerLow { get; }
        public Color SurfaceContainerHigh { get; }
        public Color SurfaceContainerHighest { get; }
        public Color OnSurface { get; }
        public Color OnSurfaceVariant { get; }
    }
}
