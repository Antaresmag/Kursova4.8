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
        public float VegFrutSum = 0;
        public VegFruitProduct()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
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

        //private void metroTextBox14_Click(object sender, EventArgs e)
        //{

        //}

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox25.Enabled = true;
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox26.Enabled = true;
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox27.Enabled = true;
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox28.Enabled = true;
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox30.Enabled = true;
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox31.Enabled = true;
        }

        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox32.Enabled = true;
        }

        private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox33.Enabled = true;
        }

        private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox34.Enabled = true;
        }

        private void metroCheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox35.Enabled = true;
        }

        private void metroCheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox36.Enabled = true;
        }

        private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox37.Enabled = true;
        }
        private void metroTextBox25_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(metroTextBox25.Text);

            }
            catch
            {
                metroTextBox25.Text = "0";
                return;
            }
            int count = Convert.ToInt32(metroTextBox25.Text);
            float cocumbers = 18;
            metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (cocumbers * count)).ToString();
            VegFrutSum += (count * cocumbers);
        }

        private void metroTextBox26_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox26.Text);

                }
                catch
                {
                    metroTextBox26.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox26.Text);
                float Tomatoes = 25;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (Tomatoes * count)).ToString();
                VegFrutSum += (count * Tomatoes);
            }
        }

        private void metroTextBox27_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox27.Text);

                }
                catch
                {
                    metroTextBox27.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox27.Text);
                float Eggplants = 40;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (Eggplants * count)).ToString();
                VegFrutSum += (count * Eggplants);
            }
        }

        private void metroTextBox28_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox28.Text);

                }
                catch
                {
                    metroTextBox28.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox28.Text);
                float Potatos = 12;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (Potatos * count)).ToString();
                VegFrutSum += (count * Potatos);
            }
        }

        private void metroTextBox30_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox30.Text);

                }
                catch
                {
                    metroTextBox30.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox30.Text);
                float mango = 120;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (mango * count)).ToString();
                VegFrutSum += (count * mango);
            }
        }

        private void metroTextBox31_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox31.Text);

                }
                catch
                {
                    metroTextBox31.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox31.Text);
                float papaya = 200;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (papaya * count)).ToString();
                VegFrutSum += (count * papaya);
            }
        }

        private void metroTextBox32_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox32.Text);

                }
                catch
                {
                    metroTextBox32.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox32.Text);
                float persimmon = 47;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (persimmon * count)).ToString();
                VegFrutSum += (count * persimmon);
            }
        }

        private void metroTextBox33_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox33.Text);

                }
                catch
                {
                    metroTextBox33.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox33.Text);
                float papaya = 117;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (papaya * count)).ToString();
                VegFrutSum += (count * papaya);
            }
        }

        private void metroTextBox34_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox34.Text);

                }
                catch
                {
                    metroTextBox34.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox34.Text);
                float veg_meet = 250;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (veg_meet * count)).ToString();
                VegFrutSum += (count * veg_meet);
            }
        }

        private void metroTextBox35_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox35.Text);

                }
                catch
                {
                    metroTextBox35.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox35.Text);
                float veg_cheese = 300;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (veg_cheese * count)).ToString();
                VegFrutSum += (count * veg_cheese);
            }
        }

        private void metroTextBox36_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox36.Text);

                }
                catch
                {
                    metroTextBox36.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox36.Text);
                float veg_milk = 69;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (veg_milk * count)).ToString();
                VegFrutSum += (count * veg_milk);
            }
        }

        private void metroTextBox37_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(metroTextBox37.Text);

                }
                catch
                {
                    metroTextBox37.Text = "0";
                    return;
                }
                int count = Convert.ToInt32(metroTextBox37.Text);
                float sp_water = 50;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (sp_water * count)).ToString();
                VegFrutSum += (count * sp_water);
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;

        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
