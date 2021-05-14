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
using System.Windows.Shapes;

namespace WpfKepnezo
{
    /// <summary>
    /// Interaction logic for KepWin.xaml
    /// </summary>
    public partial class KepWin : Window
    {
        public KepWin()
        {
            InitializeComponent();
        }

        public KepWin(Image image)
        {
            InitializeComponent();
            imageKep.Source = image.Source;
        }
    }
}
