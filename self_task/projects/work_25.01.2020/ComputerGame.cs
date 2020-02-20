using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ComputerGame
    {
        public string Name {get; set;}
        public string Dev { get; set;}
        public string Genre { get; set;}
        public DateTime ReleaseDate { get; set;}

        public ComputerGame(string cpName, string cpDev, string cpGenre, DateTime cpReleaseDate)
        {
            //cpName = Name;
            //cpDev = Dev;
            //cpGenre = Genre;
            //cpReleaseDate = ReleaseDate;

            Name = cpName;
            Dev = cpDev;
            Genre = cpGenre;
            ReleaseDate = cpReleaseDate;
        }

        public override string ToString()
        {
            return ($"{Name} {Dev} {Genre} {ReleaseDate}");
        }
    }
}
