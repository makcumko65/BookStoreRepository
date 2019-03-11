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

        [HttpGet]
        public IActionResult AddToCart(int Id)
        {
            Book game = _context.Book
                .FirstOrDefault(g => g.Id == Id);

            if (game != null)
            {
                cart.AddItem(game, 1);
            }
            else
            {
                throw new Exception("dadadadada");
            }
            return View(cart.Lines);
        }
        [HttpGet]
        public IActionResult BuyAll()
        {
            return View();
        }
        [HttpPost]
        public string BuyAll(Purchase purchase)
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
                _context.Purchase.Add(item);
                _context.SaveChanges();
            }
            return "Thanks, " + purchase.User;
        }


        //public RedirectToRouteResult RemoveFromCart(int gameId, string returnUrl)
        //{
        //    Game game = repository.Games
        //        .FirstOrDefault(g => g.GameId == gameId);

        //    if (game != null)
        //    {
        //        GetCart().RemoveLine(game);
        //    }
        //    return RedirectToAction("Index", new { returnUrl });
        //}


    }
}