using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication7
{
    class Users2
    {
        FileStream chat;
        private XDocument users = XDocument.Load("users.xml");
        private string login = "";
        private string password = "";
        private bool admin = false;

        public void setAdmin(bool _admin)
        {
            this.admin = _admin;
        }

        public void setLogin(string _login)
        {
            this.login = _login;
        }

        public void setPassword(string _password)
        {
            this.password = _password;
        }

        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }

        public bool getAdmin()
        {
            return admin;
        }

        public bool CheckRegistr(string _login, string _password)
        {
            bool registr = false;

            foreach (XElement user in users.Element("data").Element("users").Elements("user"))
            {          
                if (user.Attribute("login").Value == _login)
                {
                    if (user.Attribute("admin").Value == "true")
                    {
                        admin = true;
                    }
                    login = _login;
                    password = user.Attribute("password").Value;
                    registr = true;

                    return registr;
                }
            }

            return registr;

        }

        public bool addUserOrPublic(string _login, string _password)
        {
            bool registr = false;

            if (!CheckRegistr(_login, _password))
            {
                XElement user = new XElement("user");
                XAttribute login = new XAttribute("login", _login);
                XAttribute password = new XAttribute("password", _password);
                XAttribute admin = new XAttribute("admin", "false");
                user.Add(login, password, admin);
                users.Element("data").Element("users").Add(user);
                users.Save("users.xml");

                registr = true;
            }

            return registr;
        }

        public bool Login(string _login, string _password)
        {
            bool CheckLogined = false;

            if (CheckRegistr(_login, _password))//проверяет на регистрацию по логину.
            {
                if (password == _password)
                {
                    CheckLogined = true;
                }                    
            }
            return CheckLogined;
        }

        public string getNameChat(string login2)
        {
            string NameChat = "";

            foreach (XElement user in users.Element("data").Element("users").Elements("user"))
            {
                if (user.Attribute("login").Value == login)
                {
                    NameChat = login + "-" + login2 + ".txt";
                    return NameChat;
                }
                if (user.Attribute("login").Value == login2)
                {
                    NameChat = login2 + "-" + login + ".txt";
                    return NameChat;
                }
            }

            users.Save("users.xml");

            return NameChat;
        }

        public void getChat(string sendTo, ref TextBox readMessage)
        {
            string NameChat = getNameChat(sendTo);
            chat = new FileStream(@"Chats\" + NameChat, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(chat);

            readMessage.Text = "";
            string _message;
            while (!reader.EndOfStream)
            {
                _message = reader.ReadLine();
                readMessage.Text += _message + Environment.NewLine;
            }

            reader.Close();
        } 

        public void sendMessage(string text, string sendTo)
        {
            string NameChat = getNameChat(sendTo);
            chat = new FileStream(@"Chats\" + NameChat, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(chat);
            writer.WriteLine(getLogin() + ": " + text);

            writer.Close();
        }

        public void deleteUser(string _login)
        {
            foreach (XElement user in users.Element("data").Element("users").Elements("user"))
            {
                if (user.Attribute("login").Value == _login)
                {
                    user.Remove();
                    users.Save("users.xml");
                    break;
                }
            }
        }

        public void editUser(string _login, string newLogin, string newPassword)
        {
            foreach (XElement user in users.Element("data").Element("users").Elements("user"))
            {
                if (user.Attribute("login").Value == _login)
                {
                    string ss = user.Attribute("login").Value;
                    ss = user.Attribute("password").Value;
                    user.Attribute("login").Value = newLogin;
                    user.Attribute("password").Value = newPassword;
                    users.Save("users.xml");
                    break;
                }
            }
        }
    }
}
