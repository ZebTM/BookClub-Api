using BookClub.Models;
using BookClub.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace BookClub.Repository;

public class UserRepository : IUserRepository, IDisposable
{
    private MyDatabaseContext _dbContext;

    public UserRepository(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<SanitizedUser>> GetAllUsers()
    {
        return await _dbContext.Users
            .Select(u => new SanitizedUser(u))
            .ToListAsync();

        // Console.WriteLine("{0}", users.FirstOrDefault().Username);

        // returgcn users;
    }

    public async Task<User> InsertUser(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<User?> DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<User?> GetUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<User?> EditUser(User user)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {

    }
}
