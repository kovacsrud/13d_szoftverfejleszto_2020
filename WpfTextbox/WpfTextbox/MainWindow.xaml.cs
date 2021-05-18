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

namespace WpfTextbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textblockHossz.Text = $"A beírt szöveg hossza:{textboxSzoveg.Text.Length}";
        }

        private void textboxSzoveg_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (checkNagybetus.IsChecked==true)
            {
                textblockSzoveg.Text = textboxSzoveg.Text.ToUpper();
            } else
            {
                textblockSzoveg.Text = textboxSzoveg.Text;
            }

            

            textblockHossz.Text = $"A beírt szöveg hossza:{textboxSzoveg.Text.Length}";
        }

        private void checkNagybetus_Checked(object sender, RoutedEventArgs e)
        {
            textblockSzoveg.Text = textblockSzoveg.Text.ToUpper();
        }

        private void checkNagybetus_Unchecked(object sender, RoutedEventArgs e)
        {
            textblockSzoveg.Text = textblockSzoveg.Text.ToLower();
        }
    }
}
