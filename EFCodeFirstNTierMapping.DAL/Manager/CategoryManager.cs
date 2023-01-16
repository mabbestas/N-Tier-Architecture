using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Manager
{
    public class CategoryManager
    {
        public void AddCategory(FilmCategory filmCategory)
        {
            using (Context context = new Context())
            {
                context.FilmCategoryTable.Add(filmCategory);
                context.SaveChanges();
            }
        }



        public List<FilmCategory> GetCategory()
        {
            using (Context context = new Context())
            {
                return context.FilmCategoryTable.ToList();
            }
        }

    }
}
