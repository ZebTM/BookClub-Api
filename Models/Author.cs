
namespace BookClub.Models;

public class Author
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String Name { get; set; } = String.Empty;

    public Author() { }

    public Author(CreateAuthor author)
    {
        Id = Guid.NewGuid();
        Name = author.Name;
    }
}

public class CreateAuthor
{
    public String Name { get; set; } = String.Empty;

    public CreateAuthor() { }
}
