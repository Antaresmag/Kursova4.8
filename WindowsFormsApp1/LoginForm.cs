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
    public partial class LoginForm : Form
    {
        private List<User> users = new List<User>();
        private User user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User { Login = textBox1.Text, Password = textBox2.Text };
            if (!users.Any(elem => elem.Login == user.Login && elem.Password == user.Password))
            {
                var regForm = new RegistrationForm(ref user);
                if (regForm.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = $"Hello, {user.Login}";

                }

            }
            
        }
    }
}
