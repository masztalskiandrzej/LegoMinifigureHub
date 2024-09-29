using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class UserService
    {
        public List<User> userList;
        public bool loggedIn = false;
        public UserService() 
        {
            userList = new List<User>();
        }

        public void AddAnAccount(User account)
        {
            User newAccount = account;

            userList.Add(newAccount);

        }

        
        public void LoggingIn()
        {
            UserService userService = new UserService();
            Console.WriteLine("Enter username: ");
            var givenUsername = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            var givenPassword = Console.ReadLine();

            foreach (User user in userList)
            {
                if(user.username == givenUsername && user.password == givenPassword)
                {
                    loggedIn = true;
                }
            }

        }

    }
}
