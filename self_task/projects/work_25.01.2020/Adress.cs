using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Adress
    {
        public int Index {get;set;}
        public int Building {get;set;}
        public int  Flat{get;set;}
        public string City{get; set;}    
        public string Street{get; set;}

        public Adress(int adressIndex, int adressBuilding, int adressFlat, string adressCity, string adresStreet)
        {
            Index = adressIndex;
            Building = adressBuilding;
            Flat = adressFlat;
            City = adressCity;
            Street = adresStreet;
        }

        public override string ToString()
        {
            return ($"{Index} {Building} {Flat} {City} {Street}");
        }
    }
}
