using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class LogIn
    {
        User user = new User();

        public bool CheckCredentials(string inputUsername, string inputPassword)
        {
            if (inputUsername == user.username && inputPassword == user.password)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

    }
}