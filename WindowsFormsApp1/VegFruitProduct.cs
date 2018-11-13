using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VegFruitProduct : MetroForm
    {
        public VegFruitProduct()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox30_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox32_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox31_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox33_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextBox25_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox14_TextChanged(object sender, EventArgs e)
        {
            int temp=0;
            if (!int.TryParse(metroTextBox14.Text,out temp))
            {
                metroTextBox14.Text = "0";
            }
        }
    }
}
