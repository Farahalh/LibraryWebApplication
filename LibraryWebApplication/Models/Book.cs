namespace LibraryApi.Models;

using Microsoft.EntityFrameworkCore;

[Index(nameof(Quantity), IsUnique = true)]
public class Book
{
    public int BookID { get; set; }
    public required string BookTitle { get; set; } 
    public int ISBN { get; set; }
    public int? Rating { get; set; }
    public int Quantity { get; set; }
    public List<Author> Authors { get; set; } = new();
    public required Checkout Checkout { get; set; }
}
