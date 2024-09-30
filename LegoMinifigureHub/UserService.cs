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

        FileService fileService = new FileService();
        public List<User> userList;
        public bool loggedIn = false;
        public User loggedUser;
        public UserService() 
        {
            userList = new List<User>();
        }

        public void SigningIn(User account)
        {
            User newAccount = account;

            userList.Add(newAccount);

        }

        
        public void LoggingIn()
        {
            while (!loggedIn)
            {
                
                UserService userService = new UserService();
                Console.WriteLine("Enter username: ");
                var givenUsername = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                var givenPassword = Console.ReadLine();

                foreach (User user in userList)
                {
                    if (user.Username == givenUsername && user.Password == givenPassword)
                    {
                        loggedIn = true;
                        loggedUser = user;
                        fileService.WriteUserToFile(user);
                    }
                }

                if (!loggedIn)
                {
                    Console.WriteLine("Wrong username or password! Try again!");
                }
            }

        }

        public void PopulateUserList()
        {
            var tempFile = fileService.GetUserListFilePath;
            string[] lines = File.ReadAllLines(tempFile);

            foreach (var line in lines)
            {
                string[] data = line.Split(" || ");

                if (data.Length == 2)
                {
                    string username = (data[0]);
                    string password = data[1];


                    User user = new User() {Username = username, Password = password};
                    userList.Add(user);


                }
            }
        }

    }
}
