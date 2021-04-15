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

namespace WpfBoxok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> nevek = new List<string>();
            nevek.Add("Elek");
            nevek.Add("Ubul");
            nevek.Add("Zénó");
            nevek.Add("Ágnes");
            nevek.Add("Éva");
            nevek.Add("Jolán");

            comboboxAdatok.ItemsSource = nevek;
            listboxAdatok.ItemsSource = nevek;

            //comboboxAdatok.SelectedItem = "Elek";
            comboboxAdatok.SelectedIndex = 1;

            listboxAdatok.SelectedItem = "Jolán";
            listboxAdatok.SelectedIndex = 3;
            
        }

        private void comboboxAdatok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            labelFelso.Content = comboboxAdatok.SelectedValue;
        }

        private void listboxAdatok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            labelAlso.Content = listboxAdatok.SelectedValue;
        }
    }
}
