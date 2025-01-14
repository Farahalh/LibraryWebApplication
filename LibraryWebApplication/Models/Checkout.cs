namespace LibraryApi.Models;

public class Checkout
{
    public int CheckoutID { get; set; }
    public DateOnly DateLoaned { get; set; }
    public DateOnly DateReturned { get; set; }
    public List<Book>? Books { get; set; } = new();
    public required Borrower Borrower { get; set; }
}
