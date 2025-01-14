namespace LibraryApi.Models;

public class Borrower
{
    public int BorrowerID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public List<Checkout>? Checkout { get; set; } = new();
}
