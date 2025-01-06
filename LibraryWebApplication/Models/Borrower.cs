namespace LibraryApi.Models
{
    public class Borrower
    {
        public int BorrowerID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public char Email { get; set; }
        public bool AccountStatus { get; set; }
    }
}
