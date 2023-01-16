using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Manager
{
    public class FilmManager
    {
        // CRUD insert, update, delete, select

        public void AddFilm(Film film)
        {
            using (Context ctx = new Context())
            {
                ctx.FilmsTable.Add(film);
                ctx.SaveChanges();
            }
        }

        public void FilmUpdate(Film film)
        {
            using (Context ctx = new Context())
            {
                Film oldFilm = ctx.FilmsTable.FirstOrDefault(x => x.ID == film.ID);

                oldFilm.FilmName = film.FilmName;
                oldFilm.VisionDate = film.VisionDate;
                oldFilm.CategoryID = film.CategoryID;
                oldFilm.ModifiedDate = DateTime.Now;


                ctx.SaveChanges();
            }
        }




        public List<Film> GetFilms()
        {
            Context context = new Context();
            return context.FilmsTable.ToList();
        }
    }
}
