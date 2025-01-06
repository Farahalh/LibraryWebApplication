namespace LibraryApi.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public DateOnly SentAt { get; set; }
        public string Type { get; set; } = null!;
        public Borrower BorrowerID { get; set; }
    }
}
