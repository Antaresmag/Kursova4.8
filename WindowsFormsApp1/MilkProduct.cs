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
    public partial class MilkProduct : MetroForm
    {
        public float MilkSum = 0;
        public MilkProduct()
        {
            InitializeComponent();
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
            float chader = 100;
            metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (chader * count)).ToString();
            MilkSum += (count * chader);
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
                float bri = 500;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (bri * count)).ToString();
                MilkSum += (count * bri);
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
                float parmesan = 320;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (parmesan * count)).ToString();
                MilkSum += (count * parmesan);
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
                float mozarella = 130;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (mozarella * count)).ToString();
                MilkSum += (count * mozarella);
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
                float milk = 30;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (milk * count)).ToString();
                MilkSum += (count * milk);
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
                float yogurt = 27;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (yogurt * count)).ToString();
                MilkSum += (count * yogurt);
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
                float ryajenka = 29;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (ryajenka * count)).ToString();
                MilkSum += (count * ryajenka);
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
                float kefir = 22;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (kefir * count)).ToString();
                MilkSum += (count * kefir);
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
                float porridgeSm = 24;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (porridgeSm * count)).ToString();
                MilkSum += (count * porridgeSm);
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
                float porridgeDm = 47;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (porridgeDm * count)).ToString();
                MilkSum += (count * porridgeDm);
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
                float porridgeBig = 69;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (porridgeBig * count)).ToString();
                MilkSum += (count * porridgeBig);
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
                float porridgePr = 99;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (porridgePr * count)).ToString();
                MilkSum += (count * porridgePr);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void MilkProduct_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

