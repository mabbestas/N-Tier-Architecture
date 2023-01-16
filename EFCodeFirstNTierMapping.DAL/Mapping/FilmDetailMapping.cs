using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Mapping
{
    public class FilmDetailMapping : EntityTypeConfiguration<FilmDetail>
    {
        public FilmDetailMapping()
        {
            HasKey(x => x.ID);

            //HasRequired(x => x.FilmOfDetail).WithRequiredPrincipal(x => x.FilmDetail); kaldırdık. Çünkü farklı bir ID ortaya çıkıyor.
        }
    }
}
