using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    interface IAccount
    {
        public bool PasswordChecker(string password);

        public void ShowInfo();
        
    }
}
