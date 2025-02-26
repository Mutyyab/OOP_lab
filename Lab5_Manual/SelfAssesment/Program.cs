using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAssesment.BL;
using SelfAssesment.DL;
using SelfAssesment.UI;

namespace SelfAssesment
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentsData studentsData = new StudentsData();
            studentUI students = new studentUI();
            DegreeProgramsData ProgramsData = new DegreeProgramsData();
            DegreeUI degreeui = new DegreeUI();

            string options = studentUI.mainMenu();
            while(options != "8")
            {
                options = studentUI.mainMenu();
                switch (options)
                {
                    case "1":
                        studentsData.AddStudent(students.AddStudent());
                        break;
                    case "2":
                        ProgramsData.AddProgram(degreeui.AddDegreeProgram());
                        break;
                    case "4":
                        studentsData.RegisteredStudents();
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
