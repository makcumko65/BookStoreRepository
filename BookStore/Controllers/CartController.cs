using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CartController : Controller
    {
        private readonly BookStoreContext _context;
        static Cart cart = new Cart();
        
        public CartController(BookStoreContext context)
        {
            _context = context;
        }
        public IActionResult Cart()
        {
            return View(cart.Lines);
        }
    
        public RedirectToRouteResult AddToCart(int Id)
        {
            Book game = _context.Book
                .FirstOrDefault(g => g.Id == Id);
            if (game != null/* && cart.lineCollection.Last().Book.Id != Id*/)
            {
                cart.AddItem(game, 1);
            }
            //else
            //{
            //    continue;
            //    throw new Exception("dadadadada");
            //}
            return RedirectToRoute(new { controller = "Books", action = "Index" });
        }
        [HttpGet]
        public IActionResult BuyAll()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BuyAll(Purchase purchase)
        {
            List< Purchase> purchases = new List<Purchase>();
            foreach(CartLine carline1 in cart.Lines)
            {
                purchases.Add(new Purchase() { User = purchase.User,
                                                Address = purchase.Address,
                                                ContactPhone = purchase.ContactPhone,
                                                BookId = carline1.Book.Id});
            }
            foreach (var item in purchases)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(item);
                    _context.SaveChanges();
                }
                else
                {
                    return View();
                }

                
            }
             
            cart.Clear();
            
            
            return View("BoughtAll",purchase);
        }


        public IActionResult RemoveFromCart(int Id)
        {
            Book book = _context.Book
                .FirstOrDefault(g => g.Id == Id);

            if (book != null)
            {
                cart.RemoveLine(book);
            }
            return Redirect("/Cart/Cart");
        }


    }
}