using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAssesment.BL;

namespace SelfAssesment.DL
{
    public class StudentsData
    {
        public static List<Students> studentdata = new List<Students>();

        public StudentsData()
        {

        }
        public void AddStudent(Students student)
        {
            studentdata.Add(student);
        }

        public void RegisteredStudents()
        {
            for(int i = 0; i < studentdata.Count; i++)
            {
                Console.WriteLine($"Name: {studentdata[i].studentName} ");
                Console.WriteLine($"Age: {studentdata[i].Age} ");
                Console.WriteLine($"FSc Marks: {studentdata[i].fscMarks} ");
                Console.WriteLine($"ECAT Marks: {studentdata[i].ecatMarks} ");
            }
        }
    }

}
