using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StudGroup
    {
        public int Id{get; set; }
        public int Quantity{get; set; }
        public DateTime FormYear { get; set; }
        public string Speciality { get; set; }

        public StudGroup(int StudId, int studQuantity, DateTime studFormYear, string studSpeciality)
        {
            //StudId = Id;
            //studQuantity = Quantity;
            //studFormYear = FormYear;
            //studSpeciality = Speciality;

            Id = StudId;
            Quantity = studQuantity;
            FormYear = studFormYear;
            Speciality = studSpeciality;
        }

        public override string ToString()
        {
            return $"{Id} {Quantity} {FormYear} {FormYear} {Speciality}";
        }
    }
}
