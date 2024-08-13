namespace Model.Models
{
    public partial class User
    {
        public User()
        {
            Contacts = new HashSet<Contact>();
            Notifications = new HashSet<Notification>();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }

    }
}
