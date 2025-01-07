namespace LibraryApi.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<Book> Books { get; set; }
    }
}
