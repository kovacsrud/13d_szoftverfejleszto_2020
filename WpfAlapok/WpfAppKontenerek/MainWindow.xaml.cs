using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfAppKontenerek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GombCreate(30);

        }

        private void GombCreate(int gombDarab)
        {
            for (int i = 0; i < gombDarab; i++)
            {
                Button gomb = new Button();
                gomb.Content = $"{i + 1}.gomb";
                wrapButtons.Children.Add(gomb);
            }
        }
    }
}
