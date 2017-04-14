using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace WindowsFormsApplication7
{
    public partial class Messeger : Form
    {
        private Users2 user = new Users2();
        private XDocument users = XDocument.Load("users.xml");

        public Messeger()
        {
            InitializeComponent();
            setComboBox();
        }

        public void setComboBox()
        {
            comboBoxUsers.Items.Clear();
            comboBoxUsers.Text = "выберите пользователя";

            foreach (XElement user in users.Element("data").Element("users").Elements("user"))
            {
                if (user.Attribute("admin").Value == "false")
                {
                    comboBoxUsers.Items.Add(user.Attribute("login").Value);
                }
            }

            users.Save("users.xml");
        }

        public void checkAdmin()
        {
            if (user.getAdmin() == false)
            {
                buttonEditUser.Visible = false;
                bool asdas = buttonEditUser.Visible;
            }
        }

        public void setUser(string _Login, string _Password, bool _Admin)
        {
            user.setLogin(_Login);
            user.setPassword(_Password);
            user.setAdmin(_Admin);
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            if ((comboBoxUsers.SelectedItem == "") || (comboBoxUsers.SelectedItem == "выберите пользователя") || (sendMessage.Text == ""))
            {
                comboBoxUsers.Text = "выберите пользователя";
            }
            else
            {
                user.sendMessage(sendMessage.Text, comboBoxUsers.Text);
                sendMessage.Text = "";
                user.getChat(comboBoxUsers.Text, ref readMessage);
            }
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user.getAdmin())
            {
                buttonEditUser.Visible = true;
            }
            user.getChat(comboBoxUsers.Text, ref readMessage);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            user.deleteUser(comboBoxUsers.Text);

            setComboBox();

        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if ((comboBoxUsers.Text == "") || (comboBoxUsers.Text == "выберите пользователя"))
            {
                comboBoxUsers.Text = "выберите пользователя";
            }
            else
            {
                EditUser EditUser = new EditUser();
                EditUser.setDataUser(comboBoxUsers.Text);
                EditUser.ShowDialog();
            }
        }
    }
}
