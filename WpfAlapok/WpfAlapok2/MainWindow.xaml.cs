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

namespace WpfAlapok2
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

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var kmh = Convert.ToDouble(textboxKmh.Text);
                textblockMs.Text = $"{kmh/3.6:0.00} méter";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);               
            }
        }
    }
}
