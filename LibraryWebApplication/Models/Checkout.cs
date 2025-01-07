namespace LibraryApi.Models
{
    public class Checkout
    {
        public int CheckoutID { get; set; }
        public DateOnly DateLoaned { get; set; }
        public DateOnly DateReturned { get; set; }
        public List<Borrower> Borrowers { get; set; }

    }
}
