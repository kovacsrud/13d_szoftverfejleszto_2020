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

namespace WpfKepnezo
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

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG fájlok (*.jpg)|*.jpg";
            dialog.Multiselect = true;

            if (dialog.ShowDialog()==true)
            {
                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    var image = new Image();
                    var bitmap = new BitmapImage(new Uri(dialog.FileNames[i]));
                    image.Source = bitmap;
                    image.Width = 200;
                    image.MouseLeftButtonDown += KepClick;
                    wrappanelKepek.Children.Add(image);
                }
            }


        }

        public void KepClick(object sender,RoutedEventArgs e)
        {
            Image image = (Image)sender;
            KepWin kepwin = new KepWin(image);
            kepwin.Title = image.Source.ToString();
            kepwin.Width = image.Width;
            kepwin.Height = image.Height;
            kepwin.ShowDialog();
            
        }
    }
}
