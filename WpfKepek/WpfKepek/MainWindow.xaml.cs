﻿using Microsoft.Win32;
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

namespace WpfKepek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //kep2.Source = new BitmapImage(new Uri(@"g:\tavtanitas\13dcsharp\000046.jpg"));
            kep2.Source = new BitmapImage(new Uri("000046.jpg",UriKind.RelativeOrAbsolute));
            

        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg képek(*.jpg)|*.jpg|minden fájl(*.*)|*.*";

            if (dialog.ShowDialog()==true)
            {
                if (radiokep1.IsChecked==true)
                {
                    kep.Source = new BitmapImage(new Uri(dialog.FileName));
                } else
                {
                    kep2.Source = new BitmapImage(new Uri(dialog.FileName));
                }

                
            }

        }
    }
}
