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
                    MessageBox.Show($"Adatok száma:{dobodata.Dobok.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"HIBA!");                    
                }
            }

        }
    }
}
