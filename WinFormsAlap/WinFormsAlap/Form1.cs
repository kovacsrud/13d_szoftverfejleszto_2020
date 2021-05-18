using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAlap
{
    public partial class Szorzas : Form
    {
        public Szorzas()
        {
            InitializeComponent();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBoxA.Text);
                var b = Convert.ToDouble(textBoxB.Text);

                var eredmeny = a * b;
                labelEredmeny.Text = eredmeny.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Számot kell megadni!","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            

        }
    }
}
