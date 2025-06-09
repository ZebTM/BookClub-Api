using BookClub.Models;
namespace BookClub.Repository;

public interface IUserRepository : IDisposable
{
    Task<IEnumerable<SanitizedUser>> GetAllUsers();
    Task<User> InsertUser(User user);
    Task<User?> DeleteUser(Guid id);
    Task<User?> GetUser(Guid id);
    Task<User?> EditUser(SanitizedUser user);
    Task<User?> GetUserByUsername(String username);
}
