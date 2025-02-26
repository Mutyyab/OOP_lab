using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment.BL
{
    public class Subject
    {
        public string Code;
        public int CreditHours;
        public string Type;
        public float Fees;

        public Subject(string code,int credithours, string type, float fees)
        {
            Code = code;    
            CreditHours = credithours;
            Type = type;
            Fees = fees;
        }
    }
}
