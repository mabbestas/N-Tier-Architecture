using System.Collections.Generic;

namespace EFCodeFirstNTierMapping.DATA
{
    public class FilmCategory : BaseEntity
    {
        public string CategoryName { get; set; }

        // Navigation Property

        public virtual List<Film> FilmOfCategory { get; set; }
    }
}