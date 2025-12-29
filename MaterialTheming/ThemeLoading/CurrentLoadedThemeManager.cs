using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeProviders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeLoading
{
    public class CurrentLoadedThemeManager
    {
        private static LoadedThemeManager? _themeManagerInstance;

        public static Theme? LoadedTheme
            => GetLoadedThemeManagerInstance().CurrentLoadedTheme;

        public static Color GetColorForRole(ColorRoles role)
        {
            var instance = GetLoadedThemeManagerInstance();
            return instance.GetColorForRole(role);
        }

        public static void LoadTheme(Theme theme)
        {
            var instance = GetLoadedThemeManagerInstance();
            instance.LoadTheme(theme);
        }

        private static LoadedThemeManager GetLoadedThemeManagerInstance()
        {
            _themeManagerInstance ??= new LoadedThemeManager();

            if (!_themeManagerInstance.IsThemeLoaded)
            {
                var provider = GetThemeProviderToUse();
                var theme = provider.CreateTheme();
                _themeManagerInstance.LoadTheme(theme);
            }

            return _themeManagerInstance;
        }

        private static IThemeProvider GetThemeProviderToUse()
        {
            var discoveredThemeProvider = DefaultThemeLoadingManager.FindDefaultThemeProvider();
            if (discoveredThemeProvider != null)
                return discoveredThemeProvider;

            return new DefaultLightThemeProvider();
        }

    }
}
