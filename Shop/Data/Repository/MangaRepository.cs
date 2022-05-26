using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repository
{
    public class MangaRepository : IAllManga
    {
        private readonly AppDBContent appDBContent;

        public MangaRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Manga> Mangas => appDBContent.Manga.Include(c => c.Category);

        public IEnumerable<Manga> getFavManga => appDBContent.Manga.Where(p => p.isFavourite).Include(c => c.Category);

        public Manga getObjectManga(int mangaID) => appDBContent.Manga.FirstOrDefault(p => p.id == mangaID);
    }
}
