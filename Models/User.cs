
namespace BookClub.Models;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String Username { get; set; } = String.Empty;
}
