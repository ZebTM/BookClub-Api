using System.ComponentModel.DataAnnotations.Schema;

namespace BookClub.Models;

[Table("author")]
public class Author
{
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Column("name")]
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
