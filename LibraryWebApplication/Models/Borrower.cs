namespace LibraryApi.Models
{
    public class Borrower
    {
        public int BorrowerID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateOnly DateLoaned { get; set; }
        public DateOnly DateReturned { get; set; }
    }
}
