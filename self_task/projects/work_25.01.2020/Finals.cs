using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Finals
    {
        public string FioStudent { get; set; }
        public string FioTeacher { get; set; }
        public DateTime FinalsDate { get; set; }

        public Finals(string finalsStudent, string finalsTeacher, DateTime finalsDate)
        {
            FioStudent = finalsStudent;
            FioTeacher = finalsTeacher;
            FinalsDate = finalsDate;
        }

        public override string ToString()
        {
            return ($"{FioStudent}{FioTeacher}{FinalsDate}");
        }
    }
}
