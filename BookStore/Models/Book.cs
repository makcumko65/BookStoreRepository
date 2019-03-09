using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

    }
}
