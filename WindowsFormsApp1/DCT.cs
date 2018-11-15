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
            Front some = new Front();
           // Visible = false;
            some.ShowDialog();
           // Visible = true;
            
        }
    }
}
