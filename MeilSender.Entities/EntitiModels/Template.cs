using System.Collections.Generic;

namespace MeilSender.Entities.EntitiModels
{
    public class Template
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public virtual ICollection<Project> Project { get;set;}
        public string templateHTML { get; set; }
    }
}
