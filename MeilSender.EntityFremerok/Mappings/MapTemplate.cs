using MeilSender.Entities.EntitiModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeilSender.EntityFremerok.Mappings
{
    public class MapTemplate : EntityTypeConfiguration<Template>
    {
        public MapTemplate()
        {
            HasKey(k => k.Id).ToTable("Templates");
            Property(t => t.templateHTML).IsRequired();
        }
    }
}
