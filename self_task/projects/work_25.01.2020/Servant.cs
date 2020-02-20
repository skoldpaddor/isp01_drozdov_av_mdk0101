using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Servant
    {
        public string Name { get; set; }

        public string Job { get; set; }

        public string WorkHours { get; set; }

        public Servant(string nameserv, string jobserv, string hoursserv)
        {
            Name = nameserv;
            Job = jobserv;
            WorkHours = hoursserv;

        }
        public override string ToString()
        {
            return ($"{Name} {Job} {WorkHours}");
        }
    }
}
