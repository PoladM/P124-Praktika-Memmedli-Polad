using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class User2 : IAccount
    {
        public string FullName;
        public string Email;
        private string _password;

        public string Password
        {
            get { return _password; }

            set 
            {
                if (PasswordChecker(value) == true)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("En az 1 boyuk 1 kicik herf, 1 eded daxil edilmelidir.");
                    return;

                }
            } 
        }

        public User2(string email, string password)
        {
            Email = email;
            Password = password;
        }
        
        public bool PasswordChecker(string password)
        {
            
            while (password.Length < 8)
            {

                Console.WriteLine("Duzgun daxil et");
                password = Console.ReadLine();
            }
            
            bool check = true;
            bool check2 = true;
            bool check3 = true;
            

            foreach (var item in password)
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
                    return  true;
                }
                else
                {
                    return  false;
                }
            

           
        }

        public void ShowInfo()
        {
            Console.WriteLine("Melumat gosterilir...");
            if (Password != null)
            {
                Console.WriteLine($"{FullName} {Email}");
            }
            else
            {
                Console.WriteLine("Melumat yoxdur.");
            }
        }
    }
}
