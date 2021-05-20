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

namespace WpfAngyal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i < 41; i++)
            {
                comboboxNapok.Items.Add(i);
            }
            comboboxNapok.SelectedIndex = 0;
            textboxEladott.Text = "0";
            textboxElkeszitett.Text = "0";
            
        }

        private void ButtonHozzaad_Click(object sender, RoutedEventArgs e)
        {
            var nap = comboboxNapok.SelectedValue.ToString();
            var elkeszitett = Convert.ToInt32(textboxElkeszitett.Text);
            var eladott = Convert.ToInt32(textboxEladott.Text);
            var maradt = elkeszitett - eladott;

            if (eladott < 0 || elkeszitett < 0)
            {
                textblockHiba.Text = "Negatív számot nem adhat meg!";
            } else if (elkeszitett+maradt<eladott) {

                textblockHiba.Text = "Túl sok az eladott angyalka";
            }
            else
            {
                listboxAdatok.Items.Add($"{nap}.nap +{elkeszitett} -{eladott}={maradt}");

                for (int i = Convert.ToInt32(nap); i > 0; i--)
                {
                    comboboxNapok.Items.Remove(i);
                }
                comboboxNapok.SelectedIndex = 0;

            }

            


        }
    }
}
