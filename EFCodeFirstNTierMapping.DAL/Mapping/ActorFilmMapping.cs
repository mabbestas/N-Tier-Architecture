using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Mapping
{
    public class ActorFilmMapping : EntityTypeConfiguration<ActorFilm>
    {
        public ActorFilmMapping()
        {
            HasRequired(x => x.FilmOfActor)
                .WithMany(x => x.ActorOfFilm)
                .HasForeignKey(x => x.ActorID);

            HasRequired(x => x.ActorOfFilm)
                .WithMany(x => x.FilmsOfActor)
                .HasForeignKey(x => x.FilmID);
            Property(x => x.WorkDays).IsRequired();


        }
    }
}
