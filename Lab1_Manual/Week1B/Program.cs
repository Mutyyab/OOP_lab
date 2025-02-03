using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] user_id = new string[3];
            string[] user_name = new string[3];
            string[] user_password = new string[3];
            int user_count = 0;
            while (true)
            {
                string ans = Menu();
                if (ans == "1")
                {
                    string sinUp = signUp(user_id, user_name, user_password, user_count);
                    if (sinUp == "no")
                    {
                        Console.WriteLine("Maximum limit reached");
                        continue;
                    }
                    else if (sinUp == "No")
                    {
                        Console.WriteLine("User ID already exit");
                        continue ;
                    }
                    else if (sinUp == "Yes")
                    {
                        user_count++;
                        continue ;  
                    }
                }
                else if ( ans == "2")
                {
                    string answer = userLogin(user_id, user_name, user_password, user_count);
                    while(answer == "no")
                    {
                        Console.WriteLine("Wrong Credentials");
                        answer = userLogin(user_id, user_name, user_password, user_count);
                    }
                    if(answer == "yes")
                    {
                        userPage();
                        break;
                    }
                }
                else if(ans == "3")
                {
                    break;
                }
            }
        }
        static string Menu()
        {
            Console.WriteLine("1) Sign Up");
            Console.WriteLine("2) Sign In");
            Console.WriteLine("3) Logout");
            string options = Console.ReadLine();
            while (options != "1" && options != "2" && options != "3")
            {
                Console.WriteLine("Invalid Input");
                options = Console.ReadLine();
            }

            return options;
        }
        static string signUp(string[] user_id, string[] user_name, string[] user_password, int user_count)
        {
            string ans = "no";
            if (user_count < 3)
            {
                Console.WriteLine("Enter Your name:  ");
                user_name[user_count] = Console.ReadLine();
                string temp = user_name[user_count];
                int temp2 = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    if((temp[i] >= 65 && temp[i] <= 90) || (temp[i] >= 97 && temp[i] <= 122))
                    {
                        continue;
                    }
                    else
                    {
                        temp2 = 1;
                        break;
                    }
                }
                while (temp2 == 1)
                {
                    Console.WriteLine("Enter Your name:  ");
                    user_name[user_count] = Console.ReadLine();
                    temp = user_name[user_count];
                    temp2 = 0;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if ((temp[i] >= 65 && temp[i] <= 90) || (temp[i] >= 97 && temp[i] <= 122))
                        {
                            continue;
                        }
                        else
                        {
                            temp2 = 1;
                            break;
                        }
                    }
                }
                Console.WriteLine("Enter Your Login_id:  ");
                user_id[user_count] = Console.ReadLine();
                for (int i = 0; i < user_count; i++)
                {
                    if (user_id[user_count] == user_id[i])
                    {
                        ans = "No";
                        break;
                    }
                }
                if (ans != "No")
                {
                    Console.WriteLine("Enter Your Login_password:  ");
                    user_password[user_count] = Console.ReadLine();
                    Console.WriteLine("Signed Up SuccessFully.");
                    ans = "Yes";
                }
            }
            return ans;
        }
        static string userLogin(string[] user_id, string[] user_name, string[] user_password, int user_count)
        {
            string check1;
            string check2;
            Console.WriteLine("User-id: ");
            check1 = Console.ReadLine();
            Console.WriteLine("Password: ");
            check2 = Console.ReadLine();
            string ansr = "no";
            for (int i = 0; i < user_count; i++)
            {
                if ((check1 == user_id[i]) && (check2 == user_password[i]))
                 {
                     ansr = "yes";
                 }
            }
            return ansr;
        }
        static void userPage()
        {
            Console.WriteLine("WELCOME TO PHARMACY");
            Console.WriteLine();
            Console.WriteLine("1) Medical Store.");
            Console.WriteLine("2) Medical Equipments.");
            Console.WriteLine("3) Logout.");
        }
    }
}
