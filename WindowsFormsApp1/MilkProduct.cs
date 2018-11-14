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
    }
    }
}
