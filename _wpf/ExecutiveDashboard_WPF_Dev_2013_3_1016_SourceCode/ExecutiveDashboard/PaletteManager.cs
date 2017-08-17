using System.Collections.Generic;
using System;

namespace ExecutiveDashboard
{
    public class PaletteManager
    {
        internal static Palette _Palette;

        public static void Initialize()
        {
            _Palette = new Palette() { Source = new Uri("/ExecutiveDashboard;component/Palettes/Steel.xaml", UriKind.RelativeOrAbsolute) };
        }

        static PaletteManager()
        {
            Initialize();
            AllPalettes = new List<Palette>
            {
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Steel.xaml", UriKind.RelativeOrAbsolute)) { Name = "steel" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Caramel.xaml", UriKind.RelativeOrAbsolute)) { Name = "caramel" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Paper.xaml", UriKind.RelativeOrAbsolute)) { Name = "paper" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Ocean.xaml", UriKind.RelativeOrAbsolute)) { Name = "ocean" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Movie.xaml", UriKind.RelativeOrAbsolute)) { Name = "movie" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Tech.xaml", UriKind.RelativeOrAbsolute)) { Name = "tech" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Oak.xaml", UriKind.RelativeOrAbsolute)) { Name = "oak" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Pastel.xaml", UriKind.RelativeOrAbsolute)) { Name = "pastel" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Moon.xaml", UriKind.RelativeOrAbsolute)) { Name = "moon" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Sky.xaml", UriKind.RelativeOrAbsolute)) { Name = "sky" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Clear.xaml", UriKind.RelativeOrAbsolute)) { Name = "clear" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Ink.xaml", UriKind.RelativeOrAbsolute)) { Name = "ink" }
            };
            CustomPalettes = new List<Palette> 
            {
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Miliotis.xaml", UriKind.RelativeOrAbsolute)) { Name = "miliotis" },
                new Palette(new Uri("/ExecutiveDashboard;component/Palettes/Princess.xaml", UriKind.RelativeOrAbsolute)) { Name = "princess" }
            };
        }

        public static IEnumerable<Palette> AllPalettes
        {
            get;
            set;
        }

        public static Palette Palette
        {
            get
            {
                return PaletteManager._Palette;
            }
        }

        public static IEnumerable<Palette> CustomPalettes
        {
            get;
            private set;
        }
    }
}