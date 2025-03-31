using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;

namespace AppStyles.Theme
{
    public class Theme : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void Changed([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public enum ThemeStyle
        {
            Light_Red = 100,
            Light_Blue = 101,
            Light_Green = 102,
            Light_Gold = 103,
            Dark_Red = 200,
            Dark_Blue = 201,
            Dark_Green = 202,
            Dark_Gold = 203
        }

        public Theme(ThemeStyle style = ThemeStyle.Light_Blue)
        {
            ThemeName = style.ToString();
        }

        private string _themeName = "Light_Blue";
        public string ThemeName
        {
            get => _themeName;
            set
            {
                if (_themeName == value)
                    return;

                _themeName = value;
                Changed();
            }
        }

        private FontFamily _primaryFontFamily = new FontFamily("Calibri");
        public FontFamily PrimaryFontFamily
        {
            get => _primaryFontFamily;
            set
            {
                if (_primaryFontFamily == value)
                    return;

                _primaryFontFamily = value;
                Changed();
            }
        }

        private double _titleFontSize = 30;
        public double TitleFontSize
        {
            get => _titleFontSize;
            set
            {
                if (_titleFontSize == value)
                    return;

                _titleFontSize = value;
                Changed();
            }
        }

        private double _captionFontSize = 20;
        public double CaptionFontSize
        {
            get => _captionFontSize;
            set
            {
                if (_captionFontSize == value)
                    return;

                _captionFontSize = value;
                Changed();
            }
        }

        private double _headerFontSize = 16;
        public double HeaderFontSize
        {
            get => _headerFontSize;
            set
            {
                if (_headerFontSize == value)
                    return;

                _headerFontSize = value;
                Changed();
            }
        }

        private double _buttonFontSize = 14;
        public double ButtonFontSize
        {
            get => _buttonFontSize;
            set
            {
                if (_buttonFontSize == value)
                    return;

                _buttonFontSize = value;
                Changed();
            }
        }

        private double _textFontSize = 12;
        public double TextFontSize
        {
            get => _textFontSize;
            set
            {
                if (_textFontSize == value)
                    return;

                _textFontSize = value;
                Changed();
            }
        }

        private double _menueFontSize = 23;
        public double MenueFontSize
        {
            get => _menueFontSize;
            set
            {
                if (_menueFontSize == value)
                    return;

                _menueFontSize = value;
                Changed();
            }
        }

        private Color _primaryColor = Color.FromRgb(225, 225, 225);
        public Color PrimaryColor
        {
            get => _primaryColor;
            set
            {
                if (_primaryColor == value)
                    return;

                _primaryColor = value;
                Changed();
            }
        }

        private Color _secondaryColor = Color.FromRgb(200, 200, 200);
        public Color SecondaryColor
        {
            get => _secondaryColor;
            set
            {
                if (_secondaryColor == value)
                    return;

                _secondaryColor = value;
                Changed();
            }
        }

        private Color _backgroundColor = Color.FromRgb(255, 255, 255);
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                if (_backgroundColor == value)
                    return;

                _backgroundColor = value;
                Changed();
            }
        }

        private Color _shadowColor = Color.FromArgb(127, 0, 0, 0);
        public Color ShadowColor
        {
            get => _shadowColor;
            set
            {
                if (_shadowColor == value)
                    return;

                _shadowColor = value;
                Changed();
            }
        }

        private Color _textColor = Color.FromRgb(0, 63, 177);
        public Color TextColor
        {
            get => _textColor;
            set
            {
                if (_textColor == value)
                    return;

                _textColor = value;
                Changed();
            }
        }

        private SolidColorBrush _primaryBrush = new SolidColorBrush(Color.FromRgb(225, 225, 225));
        public SolidColorBrush PrimaryBrush
        {
            get => _primaryBrush;
            set
            {
                if (_primaryBrush == value)
                    return;

                _primaryBrush = value;
                Changed();
            }
        }

        private SolidColorBrush _secondaryBrush = new SolidColorBrush(Color.FromRgb(200, 200, 200));
        public SolidColorBrush SecondaryBrush
        {
            get => _secondaryBrush;
            set
            {
                if (_secondaryBrush == value)
                    return;

                _secondaryBrush = value;
                Changed();
            }
        }

        private SolidColorBrush _backgroundBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        public SolidColorBrush BackgroundBrush
        {
            get => _backgroundBrush;
            set
            {
                if (_backgroundBrush == value)
                    return;

                _backgroundBrush = value;
                Changed();
            }
        }

        private SolidColorBrush _shadowBrush = new SolidColorBrush(Color.FromArgb(127, 0, 0, 0));
        public SolidColorBrush ShadowBrush
        {
            get => _shadowBrush;
            set
            {
                if (_shadowBrush == value)
                    return;

                _shadowBrush = value;
                Changed();
            }
        }

        private SolidColorBrush _textBrush = new SolidColorBrush(Color.FromRgb(0, 63, 177));
        public SolidColorBrush TextBrush
        {
            get => _textBrush;
            set
            {
                if (_textBrush == value)
                    return;

                _textBrush = value;
                Changed();
            }
        }

        private LinearGradientBrush _gradient = new LinearGradientBrush(Color.FromRgb(225, 225, 225), Color.FromRgb(200, 200, 200), new Point(0.5, 1), new Point(0.5, 0));
        public LinearGradientBrush Gradient
        {
            get => _gradient;
            set
            {
                if (_gradient == value)
                    return;

                _gradient = value;
                Changed();
            }
        }
    }
}