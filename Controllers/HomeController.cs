using Microsoft.AspNetCore.Mvc;
using SolitaireSolver.Models;
using System.Diagnostics;
using static SolitaireSolver.Models.CardProperties;

namespace SolitaireSolver.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public bool ValidPlay(Card card, Card moveTo)
        {
            if (card.Type == CardType.Arcana)
            {
                if (card.ArcanaValue == 0 || card.ArcanaValue == 21)
                {
                    return true;
                }
                //need some additional logic because arcana cards have to check low and high card in the arcana board
                if (card.ArcanaValue == moveTo.ArcanaValue - 1 || card.ArcanaValue == moveTo.ArcanaValue + 1) 
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (card.Suit != moveTo.Suit)
                {
                    return false;
                }
                //add check if target is foundation
                if (card.Value == moveTo.Value - 1 || card.Value == moveTo.Value + 1)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}