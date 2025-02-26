using SelfAssesment.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment.DL
{
    public class SubjectsData
    {
        public static List<Subject> subjects = new List<Subject>();

        public SubjectsData()
        { }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }
    }
}
