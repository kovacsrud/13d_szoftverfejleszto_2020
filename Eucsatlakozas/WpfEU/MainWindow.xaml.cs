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
using Eucsatlakozas;
using Microsoft.Win32;

namespace WpfEU
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Orszaglista orszaglista;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    orszaglista = new Orszaglista(dialog.FileName,';');
                    MessageBox.Show($"Adatok száma:{orszaglista.Orszagok.Count}");
                    datagridOrszagok.ItemsSource = orszaglista.Orszagok;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                  
                }
            }
        }
    }
}
