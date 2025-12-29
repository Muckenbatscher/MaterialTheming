using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeLoading
{
    public class LoadedThemeManager
    {
        public Theme? CurrentLoadedTheme { get; private set; }
        public bool IsThemeLoaded 
            => CurrentLoadedTheme != null; 

        public void LoadTheme(Theme theme)
        {
            ArgumentNullException.ThrowIfNull(theme, nameof(theme));

            CurrentLoadedTheme = theme;
        }

        public Color GetColorForRole(ColorRoles role)
        {
            if (!IsThemeLoaded)
                throw new InvalidOperationException("No theme loaded");

            return role switch
            {
                ColorRoles.Primary => CurrentLoadedTheme!.Colors.Primary,
                ColorRoles.OnPrimary => CurrentLoadedTheme!.Colors.OnPrimary,
                ColorRoles.PrimaryContainer => CurrentLoadedTheme!.Colors.PrimaryContainer,
                ColorRoles.OnPrimaryContainer => CurrentLoadedTheme!.Colors.OnPrimaryContainer,
                ColorRoles.Secondary => CurrentLoadedTheme!.Colors.Secondary,
                ColorRoles.OnSecondary => CurrentLoadedTheme!.Colors.OnSecondary,
                ColorRoles.SecondaryContainer => CurrentLoadedTheme!.Colors.SecondaryContainer,
                ColorRoles.OnSecondaryContainer => CurrentLoadedTheme!.Colors.OnSecondaryContainer,
                ColorRoles.Tertiary => CurrentLoadedTheme!.Colors.Tertiary,
                ColorRoles.OnTertiary => CurrentLoadedTheme!.Colors.OnTertiary,
                ColorRoles.TertiaryContainer => CurrentLoadedTheme!.Colors.TertiaryContainer,
                ColorRoles.OnTertiaryContainer => CurrentLoadedTheme!.Colors.OnTertiaryContainer,
                ColorRoles.Error => CurrentLoadedTheme!.Colors.Error,
                ColorRoles.OnError => CurrentLoadedTheme!.Colors.OnError,
                ColorRoles.ErrorContainer => CurrentLoadedTheme!.Colors.ErrorContainer,
                ColorRoles.OnErrorContainer => CurrentLoadedTheme!.Colors.OnErrorContainer,
                ColorRoles.Surface => CurrentLoadedTheme!.Colors.Surface,
                ColorRoles.SurfaceContainer => CurrentLoadedTheme!.Colors.SurfaceContainer,
                ColorRoles.SurfaceContainerLowest => CurrentLoadedTheme!.Colors.SurfaceContainerLowest,
                ColorRoles.SurfaceContainerLow => CurrentLoadedTheme!.Colors.SurfaceContainerLow,
                ColorRoles.SurfaceContainerHigh => CurrentLoadedTheme!.Colors.SurfaceContainerHigh,
                ColorRoles.SurfaceContainerHighest => CurrentLoadedTheme!.Colors.SurfaceContainerHighest,
                ColorRoles.OnSurface => CurrentLoadedTheme!.Colors.OnSurface,
                ColorRoles.OnSurfaceVariant => CurrentLoadedTheme!.Colors.OnSurfaceVariant,

                _ => throw new ArgumentException("Invalid color role", nameof(role)),
            };
        }

        public bool IsDarkTheme() 
            => CurrentLoadedTheme!.IsDark;
    }
}
