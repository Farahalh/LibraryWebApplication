namespace LibraryApi.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; } = null!;
        public List<Book> Books { get; set; } = [];
    }
}
