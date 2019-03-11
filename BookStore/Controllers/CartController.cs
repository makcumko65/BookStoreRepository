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