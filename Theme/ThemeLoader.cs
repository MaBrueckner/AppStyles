using System.Windows;
using System.Windows.Media;

namespace AppStyles.Theme
{
    public class ThemeLoader
    {
        private readonly ResourceDictionary _resourceDictionary;

        public ThemeLoader(string resourceFilePath)
        {
            _resourceDictionary = new ResourceDictionary { Source = new Uri(resourceFilePath, UriKind.RelativeOrAbsolute) };
        }

        public Theme LoadTheme(Theme.ThemeStyle style)
        {
            var theme = new Theme(style);

            string prefix = style.ToString().Split('_')[0];
            string suffix = style.ToString().Split('_')[1];

            // Farben
            theme.PrimaryColor = GetColor($"{prefix}_{nameof(theme.PrimaryColor)}");
            theme.SecondaryColor = GetColor($"{prefix}_{nameof(theme.SecondaryColor)}");
            theme.BackgroundColor = GetColor($"{prefix}_{nameof(theme.BackgroundColor)}");
            theme.ShadowColor = GetColor($"{prefix}_{nameof(theme.ShadowColor)}");
            theme.TextColor = GetColor($"{style}{nameof(theme.TextColor)}");

            // Pinsel
            theme.PrimaryBrush = GetBrush($"{prefix}_{nameof(theme.PrimaryBrush)}");
            theme.SecondaryBrush = GetBrush($"{prefix}_{nameof(theme.SecondaryBrush)}");
            theme.BackgroundBrush = GetBrush($"{prefix}_{nameof(theme.BackgroundBrush)}");
            theme.ShadowBrush = GetBrush($"{prefix}_{nameof(theme.ShadowBrush)}");
            theme.TextBrush = GetBrush($"{style}{nameof(theme.TextBrush)}");

            // Verläufe
            theme.Gradient = GetLinearGradientBrush($"{prefix}_{nameof(theme.Gradient)}");

            // Schriftarten
            theme.PrimaryFontFamily = GetFontFamily($"{nameof(theme.PrimaryFontFamily)}");

            // Größen
            theme.TitleFontSize = GetDouble($"{nameof(theme.TitleFontSize)}");
            theme.CaptionFontSize = GetDouble($"{nameof(theme.CaptionFontSize)}");
            theme.HeaderFontSize = GetDouble($"{nameof(theme.HeaderFontSize)}");
            theme.ButtonFontSize = GetDouble($"{nameof(theme.ButtonFontSize)}");
            theme.TextFontSize = GetDouble($"{nameof(theme.TextFontSize)}");
            theme.MenueFontSize = GetDouble($"{nameof(theme.MenueFontSize)}");

            return theme;
        }

        private Color GetColor(string key)
        {
            if (_resourceDictionary.Contains(key) && _resourceDictionary[key] is Color color)
                return color;

            throw new KeyNotFoundException($"Key '{key}' not found in resource dictionary.");
        }

        private SolidColorBrush GetBrush(string key)
        {
            if (_resourceDictionary.Contains(key) && _resourceDictionary[key] is SolidColorBrush brush)
                return brush;

            throw new KeyNotFoundException($"Key '{key}' not found in resource dictionary.");
        }

        private LinearGradientBrush GetLinearGradientBrush(string key)
        {
            if (_resourceDictionary.Contains(key) && _resourceDictionary[key] is LinearGradientBrush brush)
                return brush;

            throw new KeyNotFoundException($"Key '{key}' not found in resource dictionary.");
        }

        private FontFamily GetFontFamily(string key)
        {
            if (_resourceDictionary.Contains(key) && _resourceDictionary[key] is FontFamily fontFamily)
                return fontFamily;

            throw new KeyNotFoundException($"Key '{key}' not found in resource dictionary.");
        }

        private double GetDouble(string key)
        {
            if (_resourceDictionary.Contains(key) && _resourceDictionary[key] is double value)
                return value;

            throw new KeyNotFoundException($"Key '{key}' not found in resource dictionary.");
        }
    }
}