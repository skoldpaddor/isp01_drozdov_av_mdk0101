using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity {get; set; }
        public int Price{get; set; }
        public DateTime ExpirationDate{get; set; }

        public Product(string productName, int productQuantity, int productPrice, DateTime productExpDate)
        {
            Name = productName;
            Quantity = productQuantity;
            Price = productPrice;
            ExpirationDate = productExpDate;
        }

        public override string ToString()
        {
            return ($"{Name}{Quantity}{Price}{ExpirationDate}");
        }
    }
}
