using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAssesment.BL;
using SelfAssesment.DL;

namespace SelfAssesment.UI
{
    public class studentUI
    {
    public static string mainMenu()
        {
            string options;
            Console.Clear();
            Console.WriteLine("1) Add Student ");
            Console.WriteLine("2) Add Degree Program");
            Console.WriteLine("3) Generate Merit");
            Console.WriteLine("4) View Registered Students");
            Console.WriteLine("5) View Students of a Specific Program");
            Console.WriteLine("6) Register Subjects for a Specific Student");
            Console.WriteLine("7) Calculate Fees for all registered Students");
            Console.WriteLine("8) Exit");
            Console.WriteLine("Enter Option");
            options = Console.ReadLine();

            return options;
        }

        public Students AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Studnet FSC Marks: ");
            float fscmarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student ECAT Marks: ");
            float ecatmarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs");

            for (int i = 0; i < DegreeProgramsData.ProgramsData.Count; i++)
            {
                Console.WriteLine(DegreeProgramsData.ProgramsData[i].Title);
            }
            Console.Write("Enter How Many Prefernces to Enter: ");
            int preferences = Convert.ToInt32(Console.ReadLine());
            List<string> preferenceList = new List<string>();
            for(int j = 0;j < preferences; j++)
            {
                preferenceList.Add(Console.ReadLine());
            }
            Students student = new Students(name, age, fscmarks, ecatmarks, preferences, preferenceList);

            return student;
        }

    }

}
