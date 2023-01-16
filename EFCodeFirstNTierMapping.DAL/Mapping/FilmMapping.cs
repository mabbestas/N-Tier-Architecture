using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Mapping
{
    public class FilmMapping : EntityTypeConfiguration<Film>
    {
        public FilmMapping()
        {
            Property(x => x.FilmName).IsRequired().HasMaxLength(65);

            ToTable("Films");

            HasRequired(x => x.FilmCategory)
                .WithMany(x => x.FilmOfCategory)
                .HasForeignKey(x => x.CategoryID);


            // 1-1 ilişki olduğunu bildirmek için yapıyoruz.
            HasRequired(x => x.FilmDetail).WithRequiredPrincipal(x => x.FilmOfDetail);
        }
    }
}
