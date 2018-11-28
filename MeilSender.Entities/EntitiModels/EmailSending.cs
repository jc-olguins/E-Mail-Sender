using System;
using System.Collections.Generic;

namespace MeilSender.Entities.EntitiModels
{
    public class EmailSending
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public virtual ICollection<Project> Project { get; set; }
        public string Code { get; set; }
        public int shipment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ShippingError { get; set; }
    }
}
