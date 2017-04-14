using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
    class UsersOld
    {
        private string Login = "";
        private string Password = "";
        private string Name = "";
        private bool Admin;

        public string GetPassword()
        {
            return Password;
        }

        public string GetLogin()
        {
            return Login;
        }

        public string GetName()
        {
            return Name;
        }

        public bool GetAdmin()
        {
            return Admin;
        }

        public void setName(string _Name)
        {
            Name = _Name;
        }

        public void setPassword(string _Password)
        {
            Password = _Password;
        }

        public void setLogin(string _Login)
        {
            Login = _Login;
        }

        public void setAdmin(bool _Admin)
        {
            Admin = _Admin;
        }


        public string CheckRegistr(string _Login)
        {
            FileStream file = new FileStream("users.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string Str = reader.ReadLine();
                Login = Str;
                Login = Login.Substring(0, 10);
                Login = Login.Replace(" ", "");
                if (Login == _Login)
                {

                    if (Login == "admin")
                    {
                        setAdmin(true);
                    }

                    Name = Str;
                    Name = Name.Substring(22, 10);
                    Name = Name.Replace(" ", "");
                    reader.Close();

                    Password = Str;
                    Password = Password.Substring(11, 10);
                    Password = Password.Replace(" ", "");
                    return Name;
                }
            }
            reader.Close();
            return Name;
        }

        public bool Registr(string _Login, string _Password, string _Name, string _Admin)
        {
            if (CheckRegistr(_Login)=="")
            {
                FileStream file2 = new FileStream("users.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file2);
                ToLength(ref _Login);
                ToLength(ref _Password);
                ToLength(ref _Name);
                ToLength(ref _Admin);
                writer.WriteLine(_Login + " " + _Password + " " + _Name + " " + _Admin);
                writer.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ToLength(ref string _Str)
        {
            while (_Str.Length < 10)
            {
                _Str = _Str + " ";
            }
        }

    }
}
