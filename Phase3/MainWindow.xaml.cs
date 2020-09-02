using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace Phase3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class ColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte R = (byte)(double)(values[0]);
            byte G = (byte)(double)(values[1]);
            byte B = (byte)(double)(values[2]);

            return Color.FromRgb(R, G, B);
        }

        //-----------------------------------------------------------------------------------------------
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}