using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manual_2
{
    class Student
    {
        public string name;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;

        public Student()
        {
            name = string.Empty;
            matricMarks = 0;
            fscMarks = 0;
            ecatMarks = 0;

        }
        public Student(string n, int m, int f, int e)
        {
            name = n;
            matricMarks = m;
            fscMarks = f;
            ecatMarks = e;
        }

        public Student AddStudent()
        {
            Student s;
            Console.WriteLine("Enter student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student matric marks: ");
            int matric = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student fsc marks: ");
            int fsc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student ecat marks: ");
            int ecat = Convert.ToInt32(Console.ReadLine());
            s = new Student(name, matric, fsc, ecat);
            return s;
        }

        public void ShowStudent()
        {
            Console.WriteLine("Student Name" + name);
            Console.WriteLine("Student matric marks" + matricMarks);
            Console.WriteLine("Student fsc marks" + fscMarks);
            Console.WriteLine("Student ecat marks" + ecatMarks);
        }
    }
}
