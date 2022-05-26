using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllManga _mangaRep;

        public HomeController(IAllManga mangaRep)
        {
            _mangaRep = mangaRep;
        }

        public ViewResult Index()
        {
            var homeManga = new HomeViewModel
            {
                favManga = _mangaRep.getFavManga
            };
            return View(homeManga);
        }
    }
}
