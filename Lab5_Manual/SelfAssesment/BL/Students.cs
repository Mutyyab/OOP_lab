using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment.BL
{
    public class Students
    {
        public string studentName;
        public int Age;
        public float fscMarks;
        public float ecatMarks;
        public float Merit;
        public int Preferences;
        public List<string> preferenceList = new List<string>();

        public Students(string studentname, int age, float fscmarks,float ecatmarks,int preference,List<string> data,float merit = 0)
        {
            studentName = studentname;
            Age = age;
            fscMarks = fscmarks;
            ecatMarks = ecatmarks;
            Merit = merit;
            preferenceList = data;
            Preferences = preference;
        }

        public Students()
        {

        }
    }
}
