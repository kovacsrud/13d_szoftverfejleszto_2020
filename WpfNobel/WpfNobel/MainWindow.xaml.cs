using Microsoft.Win32;
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

namespace WpfNobel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NobelLista nobellista;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog()==true)
            {
                try
                {
                    nobellista = new NobelLista(dialog.FileName, ';', 1);
                    MessageBox.Show($"Betöltött sorok száma:{nobellista.Nobeldijasok.Count}");
                    datagridAdatok.ItemsSource = nobellista.Nobeldijasok;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                
            }
        }

        private void ButtonKereses_Click(object sender, RoutedEventArgs e)
        {
            var eredmeny = nobellista.Nobeldijasok.FindAll(x=>x.Vezeteknev==textboxVeznev.Text);
            datagridEredmeny.ItemsSource = eredmeny;
        }
    }
}
