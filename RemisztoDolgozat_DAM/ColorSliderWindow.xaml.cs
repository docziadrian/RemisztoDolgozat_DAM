using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RemisztoDolgozat_DAM
{
    /// <summary>
    /// Interaction logic for ColorSliderWindow.xaml
    /// </summary>
    public partial class ColorSliderWindow : Window
    {
        public ColorSliderWindow()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red = (byte)rSlider.Value;
            byte green = (byte)gSlider.Value;
            byte blue = (byte)bSlider.Value;

            PanelColorChange(red, green, blue);
        }

        private void PanelColorChange(byte red, byte green, byte blue)
        {
            MainGrid.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
            caption.Foreground = new SolidColorBrush(Color.FromRgb((byte)(255 - red), (byte)(255 - green), (byte)(255 - blue))); //Átláthatóbb!
        }
    }
}
