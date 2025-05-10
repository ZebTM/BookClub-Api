using System.ComponentModel.DataAnnotations.Schema;

namespace BookClub.Models;

[Table("user_account")]
public class User
{
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("username")]
    public String Username { get; set; } = String.Empty;


    public User() { }


    public User(CreateUser userInfo)
    {
        Id = Guid.NewGuid();
        Username = userInfo.Username;
    }
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

    public SanitizedUser() { }
}

public class CreateUser
{
    public String Username { get; set; } = String.Empty;
}
