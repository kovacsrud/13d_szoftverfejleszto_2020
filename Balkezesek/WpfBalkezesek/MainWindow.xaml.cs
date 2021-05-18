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

namespace WpfBalkezesek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DoboData dobodata;
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
                    dobodata = new DoboData(dialog.FileName,1);
                    tabAdatok.IsEnabled = true;
                    tabKereso.IsEnabled = true;
                    datagridAdatok.ItemsSource = dobodata.Dobok;
                    MessageBox.Show($"Adatok száma:{dobodata.Dobok.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"HIBA!");                    
                }
            }

        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            datagridNevek.ItemsSource = null;
            datagridNevek.Items.Clear();
            var keresett = textboxNev.Text;
            //var eredmeny = dobodata.Dobok.FindAll(x=>x.Nev.ToLower()==keresett.ToLower());
            var eredmeny = dobodata.Dobok.FindAll(x => x.Nev.ToLower().Replace(" ","").Contains(keresett.ToLower().Replace(" ",""))); ;

            if (eredmeny.Count==0)
            {
                MessageBox.Show("Nincs a feltételnek megfelelő adat!");
            } else
            {
                datagridNevek.ItemsSource = eredmeny;
            }

            
        }
    }
}
