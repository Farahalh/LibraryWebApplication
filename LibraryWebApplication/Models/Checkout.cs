namespace LibraryApi.Models
{
    public class Checkout
    {
        public int CheckoutID { get; set; }
        public DateOnly DateLoaned { get; set; }
        public DateOnly DateReturned { get; set; }
        public bool IsReturned { get; set; }
        public Borrower BorrowerID { get; set; }
        public BookCopy BookCopyID { get; set; }

    }
}
