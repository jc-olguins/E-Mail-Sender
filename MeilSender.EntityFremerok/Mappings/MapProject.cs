using MeilSender.Entities.EntitiModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeilSender.EntityFremerok.Mappings
{
    public class MapProject : EntityTypeConfiguration<Project>
    {
        public MapProject()
        {
            HasKey(k => k.Id).ToTable("Projects");
            Property(p => p.Name).IsRequired();
            Property(p => p.EmailSubject).IsRequired().HasMaxLength(255);
            Property(p => p.IsActive).HasColumnAnnotation("Default", 1);
        }
    }
}
