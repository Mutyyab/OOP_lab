using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAssesment.BL;

namespace SelfAssesment.DL
{
    public class DegreeProgramsData
    {
        public static List<DegreeProgram> ProgramsData = new List<DegreeProgram>();

        public DegreeProgramsData() { }

        public void AddProgram(DegreeProgram program)
        {
            ProgramsData.Add(program);
        }
    }
}
