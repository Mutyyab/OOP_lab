using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manual_2
{
    class Muser
    {
        public string userName;
        public string password;
        public string Role;

        public Muser() { }
        public Muser(string UserName, string Password)
        {
            userName = UserName;
            password = Password;
        }
        public void PrintUserDetails()
        {
            Console.WriteLine($"Username: " + userName);
            Console.WriteLine($"Password: " + password);
            Console.WriteLine($"Role: " + Role);
        }
        public Muser LoadUserFromFile(string filePath)
        {
            Muser user = new Muser();
            string[] lines = File.ReadAllLines(filePath);
            string userName = lines[0];
            string password = lines[1];
            string role = lines[2];
            user.Role = role;
            user.password = password;
            user.userName = userName;
            return user;
        }

    }

}
