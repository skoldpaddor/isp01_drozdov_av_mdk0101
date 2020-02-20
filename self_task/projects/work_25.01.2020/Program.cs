using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //Drozdov
        static void Main(string[] args)
        {
            Student unit1 = new Student("Artyom", "Biology", "Male");
            Servant unit2 = new Servant("Elena", "Science", "8");
            Plant unit3 = new Plant("nyx12", 20);
            Book unit4 = new Book("Plame Flame", new string[] { "Vladimir Nabokov" }, 2049);
            Finals unit5 = new Finals("Yurin Nicolai Alexandrovich", "Prepodov Alexandr Formatovich ", new DateTime(2017, 06, 01, 0, 0 , 0));
            Adress unit6 = new Adress(505443, 1, 21, "NightCity", "Sovetskaia");
            Product unit7 = new Product("Raspberry ", 20, 150, new DateTime(2020, 01, 01, 0, 0, 0));
            StudGroup unit8 = new StudGroup(8, 20, new DateTime(2007, 09, 1, 8, 30, 52), "Mechanic" );
            Banknote unit9 = new Banknote(404, 256, "y3fghg34g" );
            ComputerGame unit10 = new ComputerGame("Cyberpunk 2077", "CDProjectRED", "rpg", new DateTime(2020, 04, 16, 0, 0, 0));

            Console.WriteLine($"{unit1} \n {unit2} \n {unit3} \n {unit4} \n {unit5} \n {unit6} \n {unit7} \n {unit8} \n {unit9} \n {unit10}");

            Console.ReadKey();

        }
    }
}
