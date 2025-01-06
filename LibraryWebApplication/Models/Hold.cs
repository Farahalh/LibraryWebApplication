 namespace LibraryApi.Models
{
    public class Hold
    {
        public int HoldID { get; set; }
        public DateOnly DateOnHoldStart { get; set; }
        public DateOnly DateOnHoldEnd { get; set; }
        public BookCopy BookCopyID { get; set; }
        public Borrower BorrowerID { get; set; }
    }
}
