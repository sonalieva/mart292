using System;
using System.Collections.Generic;
using System.Text;

namespace mart29
{
    class User
    {
        public User(string username)
        {
            this._userName = username;
        }
        private string _userName;
        private string _password;
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)

                {
                    _userName = value;
                }

                else
                {
                    Console.WriteLine("UserName da simvol sayi 6 ve 25 araliginda olmalidir");
                }
            }

        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value.Length >= 8 && value.Length <= 25 && char.IsDigit(value[i]) && char.IsLower(value[i]) && char.IsUpper(value[i]))
                    {
                        _password = value;
                    }
                }
            }
        }
        public bool HasDigit(string password)
        {
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public bool HasLower(string password)
        {
            foreach (var item in password)
            {
                if (char.IsLower(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool HasUpper(string password)
        {
            foreach (var item in password)
            {
                if (char.IsLower(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Username : {UserName}   Password : {Password}");
        }
    }
}

