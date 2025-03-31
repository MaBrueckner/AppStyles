using Microsoft.JSInterop;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AppStyles.Theme
{
    public class ThemeManager
    {
        private readonly ThemeLoader _themeLoader;
        private readonly IJSRuntime _jsRuntime;
        private Theme _currentTheme;

        public ThemeManager(ThemeLoader themeLoader, IJSRuntime jsRuntime)
        {
            _themeLoader = themeLoader;
            _jsRuntime = jsRuntime;
        }

        public async Task ApplyThemeAsync(Theme.ThemeStyle style, string jsMethod)
        {
            _currentTheme = _themeLoader.LoadTheme(style);

            var cssVariables = new Dictionary<string, string>();

            // Durchlaufe alle öffentlichen Properties von Theme
            foreach (PropertyInfo prop in typeof(Theme).GetProperties())
            {
                string cssVarName = $"--{ToKebabCase(prop.Name)}";

                // Hole den Wert der Eigenschaft und konvertiere ihn in einen String
                object? valueObj = prop.GetValue(_currentTheme);
                string value = valueObj?.ToString() ?? string.Empty;

                cssVariables.Add(cssVarName, value);
            }

            await _jsRuntime.InvokeVoidAsync(jsMethod, cssVariables);
        }

        private static string ToKebabCase(string input)
        {
            return Regex.Replace(input, "([a-z])([A-Z])", "$1-$2").ToLower();
        }
    }
}