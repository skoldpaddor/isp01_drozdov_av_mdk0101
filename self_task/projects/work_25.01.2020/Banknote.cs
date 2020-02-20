using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Banknote
    {
        public int NominalValue {get; set;}
        public int SeriesNumber { get; set; }
        public string NominalString { get; set; }

        public Banknote(int bnNominalValue, int bnSeriesNumber, string bnNominalString)
        {
            //bnNominalValue = NominalValue;
            //bnSeriesNumber = SeriesNumber;
            //bnNominalString = NominalString;

            NominalValue = bnNominalValue;
            SeriesNumber = bnSeriesNumber;
            NominalString = bnNominalString;
        }

        public override string ToString()
        {
            return ($"{NominalValue} {NominalString} {SeriesNumber}");
        }
    }
}
