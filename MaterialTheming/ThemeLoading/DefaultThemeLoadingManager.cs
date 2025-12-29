using M2TWinForms.Themes.ThemeProviders;
using System.Reflection;

namespace M2TWinForms.Themes.ThemeLoading
{
    public class DefaultThemeLoadingManager
    {
        public static IThemeProvider? FindDefaultThemeProvider()
        {
            var assemblies = GetOrderedRelevantAssemblies();
            foreach (var assembly in assemblies)
            {
                var assemblyThemeProvider = FindFirstDefaultThemeProviderInAssembly(assembly);
                if (assemblyThemeProvider != null)
                    return assemblyThemeProvider;
            }
            return null;
        }

        private static IEnumerable<Assembly> GetOrderedRelevantAssemblies()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var relevantAssemblies = assemblies.Where(IsRelevantAssembly);

            var entry = Assembly.GetEntryAssembly();
            Assembly? main = null;
            if (entry != null && IsRelevantAssembly(entry))
                main = entry;

            var nameOrdered = relevantAssemblies.OrderBy(a => a.GetName().Name);

            if (main == null || string.IsNullOrEmpty(main.GetName().Name))
                return nameOrdered;

            var mainName = main.GetName().Name!;
            var orderedWithoutMain = nameOrdered
                    .Where(a => !mainName.Equals(a.GetName().Name));
            var similarOrdered = OrderAssembliesByNameSimilarity(main, orderedWithoutMain);

            return similarOrdered.Prepend(main);
        }
        static bool IsRelevantAssembly(Assembly assembly)
        {
            var name = assembly.GetName().Name;
            if (string.IsNullOrEmpty(name))
                return false;

            string[] nonRelevantPrefixes = ["System", "Microsoft"];
            if (nonRelevantPrefixes.Any(p => name.StartsWith($"{p}.")))
                return false;

            string[] nonRelevantNames = ["netstandard", "mscorlib", "Accessibility", 
                "DesignToolsServer"]; //Visual Studio Winforms Designer
            if (nonRelevantNames.Contains(name))
                return false;

            return true;
        }

        private static IEnumerable<Assembly> OrderAssembliesByNameSimilarity(Assembly referenceAssembly, IEnumerable<Assembly> assemblies)
        {
            var referenceName = referenceAssembly.GetName().Name ?? string.Empty;
            return assemblies.OrderByDescending(assembly =>
            {
                var assemblyName = assembly.GetName().Name ?? string.Empty;
                return GetMatchingLength(referenceName, assemblyName);
            });
        }
        private static int GetMatchingLength(string reference, string compared)
        {
            int matchLength = 0;
            int minLength = Math.Min(reference.Length, compared.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (reference[i] == compared[i])
                    matchLength++;
                else
                    break;
            }
            return matchLength;
        }

        private static IThemeProvider? FindFirstDefaultThemeProviderInAssembly(Assembly assembly)
        {
            var types = assembly.GetTypes().OrderBy(t => t.Name);
            foreach (var type in types)
            {
                if (!IsDefaultThemeProvider(type))
                    continue;

                var instance = (IThemeProvider?)Activator.CreateInstance(type);
                if (instance != null)
                    return instance;
            }
            return null;
        }
        private static bool IsDefaultThemeProvider(Type type)
            => typeof(IDefaultThemeProvider).IsAssignableFrom(type) &&
                !type.IsInterface && !type.IsAbstract;
    }
}
