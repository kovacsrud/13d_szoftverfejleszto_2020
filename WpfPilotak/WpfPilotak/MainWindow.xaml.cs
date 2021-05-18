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

namespace WpfPilotak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PilotaData pilotadata;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()==true)
            {
                try { 
                    pilotadata = new PilotaData(dialog.FileName,';',1);
                    tabSzuletes.IsEnabled = true;
                    MessageBox.Show($"Adatok száma:{pilotadata.Pilotak.Count}");
                    comboboxEvek.ItemsSource = pilotadata.GetSzuletesiEv();

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void comboboxEvek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var aktEv = Convert.ToInt32(comboboxEvek.SelectedValue);
            var eredmeny = pilotadata.Pilotak.FindAll(x=>x.SzuletesiDatum.Year==aktEv);
            datagridEvek.ItemsSource = eredmeny;

        }
    }
}
