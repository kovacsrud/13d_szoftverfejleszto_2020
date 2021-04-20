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

namespace WpfHianyzas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TanuloAdatok tanuloAdatok;
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
                    tanuloAdatok = new TanuloAdatok(dialog.FileName, ';', 1);
                    datagridHianyzok.ItemsSource = tanuloAdatok.Tanulok;
                    MessageBox.Show($"Adatok száma:{tanuloAdatok.Tanulok.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                  
                }

            }
        }

        private void buttonNevKeres_Click(object sender, RoutedEventArgs e)
        {
            var keresettNev = textboxNev.Text;
                        

            var eredmenyLista = tanuloAdatok.Tanulok.FindAll(x=>x.Nev==keresettNev);
            if (eredmenyLista.Count>0)
            {
                datagridEredmeny.ItemsSource = eredmenyLista;
            } else
            {
                MessageBox.Show("Nincs a feltételnek megfelelő adat!");
            }
        }
    }
}
