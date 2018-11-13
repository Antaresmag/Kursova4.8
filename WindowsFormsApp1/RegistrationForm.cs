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
    public partial class RegistrationForm : Form
    {
        private User user;

        public RegistrationForm()
        {
            InitializeComponent();
            
        }

        public RegistrationForm(ref User user)
        {
            InitializeComponent();
            this.user = user;
            textBox1.Text = user.Login;
            textBox2.Text = user.Password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Login = textBox1.Text;
            user.Password = textBox2.Text;
            this.Close();
            Front some = new Front();
            some.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
