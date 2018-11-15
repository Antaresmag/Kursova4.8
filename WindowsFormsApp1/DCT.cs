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
    public partial class DCT : MetroForm
    {
        public float TehnologySum = 0;
        public DCT()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Front some = new Front();
           // Visible = false;
           // some.ShowDialog();
           // Visible = true;
            
        }

        private void DCT_Load(object sender, EventArgs e)
        {

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
            float lenovoY520 = 25000;
            metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (lenovoY520 * count)).ToString();
            TehnologySum += (count * lenovoY520);
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
                float lenovoY720 = 45500;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (lenovoY720 * count)).ToString();
                TehnologySum += (count * lenovoY720);
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
                float lenovoY920 = 70000;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (lenovoY920 * count)).ToString();
                TehnologySum += (count * lenovoY920);
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
                float xiomi = 4000;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (xiomi * count)).ToString();
                TehnologySum += (count * xiomi);
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
                float meizu = 8000;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (meizu * count)).ToString();
                TehnologySum += (count * meizu);
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
                float huawei = 6000;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (huawei * count)).ToString();
                TehnologySum += (count * huawei);
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
                float iPhone = 2500;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (iPhone * count)).ToString();
                TehnologySum += (count * iPhone);
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
                float mac = 12000;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (mac * count)).ToString();
                TehnologySum += (count * mac);
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
                float iPad = 1000;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (iPad * count)).ToString();
                TehnologySum += (count * iPad);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {

        }
    }
}
