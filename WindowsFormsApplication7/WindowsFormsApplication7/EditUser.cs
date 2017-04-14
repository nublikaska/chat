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
    public partial class EditUser : Form
    {
        string userEdit = "";
        Users2 user = new Users2();

        public EditUser()
        {
            InitializeComponent();
        }

        public void setDataUser(string _login)
        {
            user.CheckRegistr(_login, "random");
            textBoxLogin.Text = user.getLogin();
            textBoxPassword.Text = user.getPassword();
            userEdit = user.getLogin();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!user.CheckRegistr(textBoxLogin.Text, textBoxPassword.Text))
            {
                labelLogin.Text = "Логин";
                user.editUser(userEdit, textBoxLogin.Text, textBoxPassword.Text);
                this.Hide();
            }
            else
            {
                labelLogin.Text = "Такой логин уже существует";
            }
        }
    }
}
