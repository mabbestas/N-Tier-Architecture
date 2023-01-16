using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DATA
{
    public class Film : BaseEntity
    {
        public string FilmName { get; set; }
        public DateTime VisionDate { get; set; }
        public int CategoryID { get; set; }

        // Navigation Property
        public virtual FilmCategory FilmCategory { get; set; }

        public virtual FilmDetail FilmDetail { get; set; }

        // Films can have many actor and actress.

        public virtual List<ActorFilm> ActorOfFilm { get; set; }

    }
}
