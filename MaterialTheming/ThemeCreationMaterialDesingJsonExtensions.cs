using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeBuilderConversion.SerializationModels;
using M2TWinForms.Themes.ThemeBuilderConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes
{
    public partial class Theme
    {
        public static Theme CreateFromMaterialDesignJson(string materialDesignJson, ThemeMode mode, ContrastLevel contrastLevel)
        {
            var deserializer = new MaterialThemeDeserializer();
            var materialTheme = deserializer.Deserialize(materialDesignJson);
            if (materialTheme == null)
                throw new ArgumentException("Material design theme could not be parsed from the supplied JSON content.");
            var converter = new ThemeBuilderConverter();
            Scheme? selectedScheme = null;
            if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.Normal)
                selectedScheme = materialTheme.Schemes.Light;
            else if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.Medium)
                selectedScheme = materialTheme.Schemes.LightMediumContrast;
            else if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.High)
                selectedScheme = materialTheme.Schemes.LightHighContrast;
            else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.Normal)
                selectedScheme = materialTheme.Schemes.Dark;
            else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.Medium)
                selectedScheme = materialTheme.Schemes.DarkMediumContrast;
            else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.High)
                selectedScheme = materialTheme.Schemes.DarkHighContrast;
            else
                throw new ArgumentException("Invalid combination of theme mode and contrast level.");

            if (selectedScheme == null)
                throw new ArgumentException($"The requested combination of {nameof(ThemeMode)}: {mode} and {nameof(ContrastLevel)}: {contrastLevel} was not present in the supplied JSON content.");

            var themeColors = converter.ConvertFromThemeBuilder(selectedScheme);
            bool isDark = mode == ThemeMode.Dark;
            return new Theme()
            {
                Colors = themeColors,
                IsDark = isDark,
            };
        }

        public static Theme CreateFromMaterialDesignJson(FileInfo materialDesignJsonFile, ThemeMode mode, ContrastLevel contrastLevel)
        {
            materialDesignJsonFile.Refresh();
            if (!materialDesignJsonFile.Exists)
                throw new FileNotFoundException("Material Design JSON file not found.", materialDesignJsonFile.FullName);

            var materialDesignJson = File.ReadAllText(materialDesignJsonFile.FullName);
            return CreateFromMaterialDesignJson(materialDesignJson, mode, contrastLevel);
        }
    }
}
