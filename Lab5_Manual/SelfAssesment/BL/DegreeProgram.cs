using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment.BL
{
    public class DegreeProgram
    {
        public string Title;
        public string Duration;
        public int Seats;
        public int Subjects;
        public List<string> Subjects_of_degree = new List<string>();

        public DegreeProgram(string title,string duration,int seats,int subjects,List<string> subjectsOfDegree)
        {
            Title = title;
            Duration = duration;
            Seats = seats;
            Subjects = subjects;
            Subjects_of_degree = subjectsOfDegree;
        }
    }
}
