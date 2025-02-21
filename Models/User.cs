using System.ComponentModel.DataAnnotations.Schema;

namespace BookClub.Models;

[Table("user_account")]
public class User
{
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("username")]
    public String Username { get; set; } = String.Empty;
}


public class SanitizedUser
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String Username { get; set; } = String.Empty;
    public Boolean Sanitized { get; set; } = true;
    public SanitizedUser(User user)
    {
        Id = user.Id;
        Username = user.Username;
    }
}

public class CreateUser
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String Username { get; set; } = String.Empty;
}
