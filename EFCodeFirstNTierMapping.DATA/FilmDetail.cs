using System.Collections.Generic;

namespace EFCodeFirstNTierMapping.DATA
{
    public class FilmDetail : BaseEntity
    {
        public string DetailOfFilm { get; set; }

        // Navigaton Property
        public virtual Film FilmOfDetail { get; set; }
    }
}