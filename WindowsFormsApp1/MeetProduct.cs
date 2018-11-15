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
    public partial class MeetProduct : MetroForm
    {
        public float MeetSum=0;
        public MeetProduct()
        {
            InitializeComponent();
        }

        private void MeetProduct_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox25.Enabled = true;
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox26.Enabled = true;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

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
            float sousage = 100;
            metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (sousage * count)).ToString();
            MeetSum += (count * sousage);
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

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
                float dump = 60;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (dump * count)).ToString();
                MeetSum += (count * dump);
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
                float stew = 89;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (stew * count)).ToString();
                MeetSum += (count * stew);
            }
        }

        private void metroTextBox35_Click(object sender, EventArgs e)
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
                float pate = 40;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (pate * count)).ToString();
                MeetSum += (count * pate);
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
                float shinz = 100;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (shinz * count)).ToString();
                MeetSum += (count * shinz);
            }
        }

        private void metroTextBox11_Click(object sender, EventArgs e)
        {

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
                float ham = 150;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (ham * count)).ToString();
                MeetSum += (count * ham);
            }
        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            
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
                float becone = 320;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (becone * count)).ToString();
                MeetSum += (count * becone);
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
                float pork_fat = 110;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (pork_fat * count)).ToString();
                MeetSum += (count * pork_fat);
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
                float beef = 200;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (beef * count)).ToString();
                MeetSum += (count * beef);
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
                float pork = 160;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (pork * count)).ToString();
                MeetSum += (count * pork);
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
                float chiken = 140;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (chiken * count)).ToString();
                MeetSum += (count * chiken);
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
                float mutton = 200;
                metroTextBox14.Text = (float.Parse(metroTextBox14.Text) + (mutton * count)).ToString();
                MeetSum += (count * mutton);
            }
        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void metroTextBox13_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!! Увага НЕ натискайте, мишкою двійчі по вікні (кількості товарів) доки ви не ували потрібну кількість товару, коли вирішите з кількістю тоді, натисніть другий раз! Якщо раптом ви випадково ви натиснули двічі і вибрали не ту кількість через знак - відніміть потрібну кількість");
        }
    }
}
