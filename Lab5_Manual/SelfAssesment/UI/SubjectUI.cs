using SelfAssesment.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAssesment.BL;

namespace SelfAssesment.UI
{
    public class SubjectUI
    {
        public SubjectUI()
        {

        }

        public Subject AddSubject()
        {
            Console.Write("5) Enter subject Code: ");
            string code = Console.ReadLine();
            Console.Write("6) Enter Subject Type(Name): ");
            string Type = Console.ReadLine();
            Console.Write("7) Enter Subject Credit Hours: ");
            int creditHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("8) Enter Subject Fees: ");
            float fees = float.Parse(Console.ReadLine());

            Subject subject = new Subject(code,creditHours,Type,fees);
            return subject;
        }


    }
}
