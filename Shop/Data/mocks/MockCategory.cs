using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : IMangaCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Сёнен", desc = "Манга для мальчиков от 12 до 18 лет"},
                    new Category { categoryName = "Сэйнен", desc = "Манга для мужчин от 18 лет"},
                    new Category { categoryName = "BL", desc = "Манга boys' love"}
                };
            }
        }
    }
}
