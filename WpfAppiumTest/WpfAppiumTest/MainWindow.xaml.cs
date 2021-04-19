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

namespace WpfAppiumTest
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
                var a = Convert.ToDouble(textboxA.Text);
                var b = Convert.ToDouble(textboxb.Text);
                var c = a / b;
                textblockEredmeny.Text = $"{c:0.00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);           
            }
            
        }
    }
}
