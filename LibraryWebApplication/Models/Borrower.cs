namespace LibraryApi.Models
{
    public class Borrower
    {
        public int BorrowerID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<Checkout> Checkouts { get; set; }
    }
}
