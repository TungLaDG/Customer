namespace Model.Models
{
    public class Notification
    {
        //public virtual Depot? Cars { get; set; }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? Status { get; set; }
        public string? Type { get; set; }
        public int? UserID { get; set; }
        public int? CarID { get; set; }
    }
}
