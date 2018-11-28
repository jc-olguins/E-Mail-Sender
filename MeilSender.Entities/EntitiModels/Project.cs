namespace MeilSender.Entities.EntitiModels
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailSubject { get; set; }
        public virtual Template Template { get; set; }
        public virtual EmailSending EmailSending { get; set; }
        public bool IsActive { get; set; }
    }
}
