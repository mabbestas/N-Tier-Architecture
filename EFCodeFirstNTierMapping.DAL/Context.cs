using EFCodeFirstNTierMapping.DAL.Mapping;
using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL
{
    public class Context : DbContext
    {
        public Context() : base(@"Server=(localdb)\MSSQLLocalDB; Database=EFDetailMappingDB; Trusted_Connection=True;")
        {
                
        }

        public DbSet<Film> FilmsTable { get; set; }

        public DbSet<Actor> ActorTable { get; set; }

        public DbSet<FilmCategory> FilmCategoryTable { get; set; }

        public DbSet<FilmDetail> FilmDetailsTable { get; set; }

        public DbSet<ActorFilm> ActorFilmsTable { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new FilmDetailMapping());

            modelBuilder.Configurations.Add(new FilmMapping());

            modelBuilder.Configurations.Add(new ActorFilmMapping());



            base.OnModelCreating(modelBuilder);
        }


    }
}
