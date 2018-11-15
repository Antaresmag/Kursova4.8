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
        public float GlobalSum = 0;
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
            metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (GlobalSum += some.ProductSum)).ToString();
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
            MessageBox.Show("Зверніть увагу на знак ? і натисність");
            DCT some = new DCT();
            some.ShowDialog();
            metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (GlobalSum += some.TehnologySum)).ToString();
           

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           metroTextBox14.Text = float.Parse(metroTextBox14.Text).ToString();
            MessageBox.Show("You sum = "+(metroTextBox14.Text));
           
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-_- І на* ти нам голову морочіш, ШТРАФ "+metroTextBox14.Text);
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UA: Ви можете гуляти по нашому, магазину. Скидувати товари у кошик. А коли закінчіте, натисніть копку BAY / Do not Bay");
        }

        //private void metroButton3_Click(object sender, EventArgs e)
        //{
        //    MeetProduct some = new MeetProduct();
        //    some.Enabled = true;
        //    some.ShowDialog();
        //}

        //private void metroButton4_Click(object sender, EventArgs e)
        //{
        //    MilkProduct some = new MilkProduct();
        //    some.ShowDialog();
        //}

        //private void metroButton5_Click(object sender, EventArgs e)
        //{
        //    VegFruitProduct some = new VegFruitProduct();
        //    some.ShowDialog();
        //}
    }
}
