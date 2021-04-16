using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfDinamikus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GombKeszit(88);
        }

        private void GombKeszit(int db)
        {
            for (int i = 0; i < db; i++)
            {
                Button gomb = new Button();
                gomb.Content = $"{i+1}.gomb";
                gomb.Margin = new Thickness(5);
                gomb.Width = 100;
                gomb.Click += GombClick;
                wrapGombok.Children.Add(gomb);
            }
        }

        private void GombClick(object sender,RoutedEventArgs e)
        {
           
            Button gomb = (Button)sender;
            gomb.FontWeight = FontWeights.Bold;

            
            gomb.Foreground = Brushes.Red;
            gomb.Background = Brushes.Blue;
            textblockSorszam.Text = gomb.Content.ToString();
        }
       
    }
}
