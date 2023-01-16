using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DATA
{
    public class Actor : BaseEntity
    {
        public string ActorName { get; set; }
        public DateTime BirthDate { get; set; }
        public string LifeOfActor { get; set; }

        // Navigations Property
        // Actor can has many films.

        public virtual List<ActorFilm> FilmsOfActor { get; set; }
    }
}
