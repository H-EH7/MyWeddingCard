using Microsoft.AspNetCore.Mvc;
using MyWeddingCard.Models;
using System.Diagnostics;

namespace MyWeddingCard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
