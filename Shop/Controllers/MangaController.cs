using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class MangaController : Controller 
    {
        private readonly IAllManga _allManga;
        private readonly IMangaCategory _allCategories;
        
        public MangaController(IAllManga iAllManga, IMangaCategory iMangaCat)
        {
            _allManga = iAllManga;
            _allCategories = iMangaCat;
        }

        [Route("Manga/List")]
        [Route("Manga/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Manga> manga = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                manga = _allManga.Mangas.OrderBy(i => i.id);
            }
            else
            {
                //seinen yaoi
                if (string.Equals("shounen", category, StringComparison.OrdinalIgnoreCase))
                {
                    manga = _allManga.Mangas.Where(i => i.Category.categoryName.Equals("Сёнен")).OrderBy(i => i.id);
                    currCategory = "Сёнен";
                }
                else if (string.Equals("seinen", category, StringComparison.OrdinalIgnoreCase))
                {
                    manga = _allManga.Mangas.Where(i => i.Category.categoryName.Equals("Сэйнен")).OrderBy(i => i.id);
                    currCategory = "Сэйнен";
                }
                else if (string.Equals("yaoi", category, StringComparison.OrdinalIgnoreCase))
                {
                    manga = _allManga.Mangas.Where(i => i.Category.categoryName.Equals("BL")).OrderBy(i => i.id);
                    currCategory = "BL";
                }

            }

            var mangaObj = new MangaListViewModel
            {
                allManga = manga,
                currCategory = currCategory
            };
        ViewBag.Title = "Страница с мангой";
            return View(mangaObj);
        }
    }
}

