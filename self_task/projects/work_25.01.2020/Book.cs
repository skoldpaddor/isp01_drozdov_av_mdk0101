using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public int Price { get; set; }

        public Book(string book, string[] authorsList, int BookPrice)
        {
            Title = book;
            Authors = authorsList;
            Price = BookPrice;

        }
        public override string ToString()
        {
            string res = Title + " " + Price + " ";

            foreach (var author in Authors)
                res += author + " ";


            return res;
        }
    }
}
