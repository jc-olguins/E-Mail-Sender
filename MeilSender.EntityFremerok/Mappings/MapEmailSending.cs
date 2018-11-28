using MeilSender.Entities.EntitiModels;
using System;
using System.Data.Entity.ModelConfiguration;

namespace MeilSender.EntityFremerok.Mappings
{
    public class MapEmailSending : EntityTypeConfiguration<EmailSending>
    {
        public MapEmailSending()
        {
            HasKey(s => s.Id).ToTable("MapEmailSendings");
            Property(s => s.StartDate).HasColumnAnnotation("Default", DateTime.Now);
        }
    }
}
