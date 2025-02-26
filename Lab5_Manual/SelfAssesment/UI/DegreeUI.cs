using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAssesment.BL;
using SelfAssesment.DL;

namespace SelfAssesment.UI
{
    public class DegreeUI
    {
        SubjectsData subjectdata = new SubjectsData();
        SubjectUI subjectui = new SubjectUI();

        public DegreeUI()
        {

        }
        public DegreeProgram AddDegreeProgram()
        {
            Console.Write("1) Enter Degree Name: ");
            string title = Console.ReadLine();
            Console.Write("2) Enter Degree Duration: ");
            string duration = Console.ReadLine();
            Console.Write("3) Enter Seats for Degree: ");
            int seats = Convert.ToInt32(Console.ReadLine());
            Console.Write("4) Enter How Many Subjects To Enter: ");
            int subjects = Convert.ToInt32(Console.ReadLine());
            List<string> degreeLists = new List<string>();
            for(int i = 0; i < subjects; i++)
            {
                subjectdata.AddSubject(subjectui.AddSubject());
                degreeLists.Add(SubjectsData.subjects[i].Code);

            }

            DegreeProgram degree = new DegreeProgram(title,duration,seats,subjects,degreeLists);
            return degree;
        }
    }
}
