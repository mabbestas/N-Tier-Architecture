using EFCodeFirstNTierMapping.DAL.Manager;
using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.BLL
{
    public class CategoryService
    {
        public void AddCategory(FilmCategory filmCategory)
        {
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.AddCategory(filmCategory);
        }


        public List<FilmCategory> GetCategories()
        {
            CategoryManager categoryManager = new CategoryManager();
            return categoryManager.GetCategory();
        }
    }
}
