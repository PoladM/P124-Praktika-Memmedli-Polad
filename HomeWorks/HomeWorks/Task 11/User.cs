using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class User
    {
        private string _username;
        private string _password;

        public string UserName
        {
            get
            {
                return _username;
            }
            
        }
        public string Password 
        { get { return _password; } 
            set 
            {
                while (true)
                {
                    while (value.Length < 8)
                    {
                        Console.WriteLine("Duzgun daxil et");
                        value = Console.ReadLine();
                    }

                    
                    bool check = true;
                    bool check2 = true;
                    bool check3 = true;

                    foreach (var item in value)
                    {
                        if (Char.IsDigit(item))
                        {
                            check = false;
                        }
                        else if (Char.IsLower(item))
                        {
                            check2 = false;
                        }
                        else if (Char.IsUpper(item))
                        {
                            check3 = false;
                        }
                    }

                    if (check == false && check2 == false && check3 == false)
                    {
                        _password = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("En az 1 boyuk herf bir kicik herf ve 1 sayi olmalidir!");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        public User(string username)
        {
            _username = username;
        }
    }
}
