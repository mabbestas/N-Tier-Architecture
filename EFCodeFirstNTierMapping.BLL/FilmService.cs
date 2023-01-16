using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.BLL
{
    public class FilmService
    {
        public void AddFilm(Film film)
        {
            DAL.Manager.FilmManager filmManager = new DAL.Manager.FilmManager();

            film.AddedDate = DateTime.Now;
            film.ModifiedDate = DateTime.Now;
            film.IsActive = true;
            film.VisionDate = new DateTime(2022, 02, 02);
            film.FilmDetail.AddedDate = DateTime.Now;
            film.FilmDetail.IsActive = true;
            film.FilmDetail.ModifiedDate = DateTime.Now;

            filmManager.AddFilm(film);
        }


        public List<Film> GetFilms()
        {
            DAL.Manager.FilmManager filmManager = new DAL.Manager.FilmManager();
            return filmManager.GetFilms();
        }
    }
}
