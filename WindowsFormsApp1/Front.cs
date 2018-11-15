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
    public partial class Front : MetroForm
    {
        public float Sum = 0;
        public Front()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DP some = new DP();
            some.ShowDialog();
            //Visible = true;
            
            
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Front_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DCT some = new DCT();
            some.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MeetProduct some = new MeetProduct();
            some.Enabled = true;
            some.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MilkProduct some = new MilkProduct();
            some.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            VegFruitProduct some = new VegFruitProduct();
            some.ShowDialog();
        }
    }
}
