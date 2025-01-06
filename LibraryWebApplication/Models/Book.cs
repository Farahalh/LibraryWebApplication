namespace LibraryApi.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public bool OnLoan { get; set; }
        public string BookTitle { get; set; } = null!;
        public int ISBN { get; set; }
        public int Rating { get; set; }
        public Borrower BorrowerID { get; set; }
        public List<Author> Authors { get; set; } = [];
    }
}
