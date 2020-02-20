using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Plant
    {
        public string Id { get; set; }
        public int QuantityOfWorkers { get; set; }

        public Plant(string idPlant, int PlantQuantity)
        {
            Id = idPlant;
            QuantityOfWorkers = PlantQuantity;
        }
        public override string ToString()
        {
            return $"{Id}, {QuantityOfWorkers}";
        }
    }
}
