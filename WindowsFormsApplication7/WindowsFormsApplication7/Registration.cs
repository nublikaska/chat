using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users2 user = new Users2();
            if (user.addUserOrPublic(LoginBox.Text, PasswordBox.Text))
            {
                LoginLable.Text = "Логин";
                this.Hide();
            }
            else
            {
                LoginLable.Text = "Такой логин уже существует";
            }
        }
    }
}
