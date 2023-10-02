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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tema2_imagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetOpacidad(object sender, RoutedEventArgs e)
        {
            if(altaRadioBtn.IsChecked == true) { imagen.Opacity = 1; }
            else if(mediaRadioBtn.IsChecked == true) { imagen.Opacity = 0.6; }
            else if(bajaRadioBtn.IsChecked == true) { imagen.Opacity = 0.3; }
        }

        private void SetStretch(object sender, RoutedEventArgs e)
        {

            if(noneRadioBtn.IsChecked == true) { imagen.Stretch = Stretch.None; }
            else if (fillRadioBtn.IsChecked == true) { imagen.Stretch = Stretch.Fill; }
            else if (uniformRadioBtn.IsChecked == true) { imagen.Stretch = Stretch.Uniform; }

            /*
             * none
             * fill
             * uniform
             * uniformtofill
             * 
             */

        }
    }
}
