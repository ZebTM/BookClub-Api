
namespace BookClub.Models;

public class Author
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String Name { get; set; } = String.Empty;
}
