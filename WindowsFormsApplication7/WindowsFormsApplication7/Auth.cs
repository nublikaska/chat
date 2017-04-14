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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            newForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users2 user = new Users2();
            if (user.Login(LoginBox.Text, PasswordBox.Text))
            {
                Messeger newFormMessenger = new Messeger();
                newFormMessenger.setUser(user.getLogin(), user.getPassword(), user.getAdmin());
                newFormMessenger.checkAdmin();
                this.Hide();
                newFormMessenger.Show();
            }
           


        }
    }
}
