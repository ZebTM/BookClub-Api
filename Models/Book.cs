
namespace BookClub.Models;

public class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String Title { get; set; } = String.Empty;
    public IEnumerable<Author> Authors { get; set; } = new List<Author>();
    public IEnumerable<Chapter> Chapters { get; set; } = new List<Chapter>();
}
