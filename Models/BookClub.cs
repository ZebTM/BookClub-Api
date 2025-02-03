
namespace BookClub.Models;

public class BookClub
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public IEnumerable<User> Users { get; set; } = new List<User>();
    public String Title { get; set; } = String.Empty;
}
