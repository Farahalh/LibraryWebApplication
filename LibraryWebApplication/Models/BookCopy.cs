namespace LibraryApi.Models
{
    public class BookCopy
    {
        public int BookCopyID { get; set; }
        public int YearPublished { get; set; }
        public Book BookdID { get; set; }
        public List<Borrower> Borrowers { get; set; } = [];
    }
}
