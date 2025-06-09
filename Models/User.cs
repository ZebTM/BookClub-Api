using System.ComponentModel.DataAnnotations.Schema;

namespace BookClub.Models;

[Table("user_account")]
public class User
{
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("username")]
    public String Username { get; set; } = String.Empty;

    [Column("hashed_password")]
    public String HashedPassword { get; set; } = String.Empty;

    [Column("email")]
    public String Email { get; set; } = String.Empty;

    public User() { }


    public User(CreateUser userInfo)
    {
        Id = Guid.NewGuid();
        Username = userInfo.Username;
        HashedPassword = userInfo.Password;
        Email = userInfo.Email;
    }
}


public class SanitizedUser
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String Username { get; set; } = String.Empty;
    public Boolean Sanitized { get; set; } = true;
    public String Email { get; set; } = String.Empty;

    public SanitizedUser(User user)
    {
        Id = user.Id;
        Username = user.Username;
        Email = user.Email;
    }

    public SanitizedUser() { }
}

public class CreateUser
{
    public String Username { get; set; } = String.Empty;
    public String Email { get; set; } = String.Empty;
    public String Password { get; set; } = String.Empty;
}
