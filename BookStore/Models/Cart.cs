using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Cart
    {
        public List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Book book, int quantity)
        {
            CartLine line = new CartLine(book, quantity);

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                lineCollection.Add(line);
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Book book)
        {
            lineCollection.RemoveAll(l => l.Book.Id == book.Id);
        }

        //public decimal ComputeTotalValue()
        //{
        //    return lineCollection.Sum(e => e.Book.Price * e.Quantity);

        //}
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
    //    public int BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public CartLine() { }
        public CartLine(Book book, int quantity)
        {
            Book = book;
            Quantity = quantity;
        }
    }
}
