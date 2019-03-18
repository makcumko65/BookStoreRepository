using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Cart
    {
        public List<CartLine> lineCollection = new List<CartLine>();
        public static int TotalPrice {get;set;}
        public void AddItem(Book book, int quantity)
        {
            TotalPrice += book.Price;
            //CartLine line = new CartLine(book, quantity);
            CartLine line = lineCollection
                .Where(g => g.Book.Id == book.Id)
                .FirstOrDefault();
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
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Book book)
        {
            foreach (CartLine cartline in lineCollection)
            {
                if (cartline.Book.Id == book.Id)
                {
                    if (cartline.Quantity > 1)
                    {
                        cartline.Quantity -= 1;
                        TotalPrice -= cartline.Book.Price;
                        return;
                    }
                    else
                    {
                        TotalPrice -= cartline.Book.Price;
                        lineCollection.RemoveAll(l => l.Book.Id == book.Id);
                        return;
                    }
                }
            }
            //
            //lineCollection.RemoveAll(l => l.Book.Id == book.Id);
       }

        //public decimal ComputeTotalValue()
        //{
        //    return lineCollection.Sum(e => e.Book.Price * e.Quantity);

        //}
        public void Clear()
        {
            TotalPrice = 0;
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
