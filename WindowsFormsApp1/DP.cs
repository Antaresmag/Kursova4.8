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
    public partial class DP : MetroForm
    {
        public float Sum = 0;
        public DP()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Front some = new Front();
            //some.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MeetProduct some = new MeetProduct();
            some.Enabled = true;
            some.ShowDialog();
            Sum += some.MeetSum;
            
        }

        private void DP_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MilkProduct some = new MilkProduct();
            some.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
