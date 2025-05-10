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
    }

    public async Task<User> InsertUser(User user)
    {
        try
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public async Task<User?> DeleteUser(Guid id)
    {
        try
        {
            User? user = await _dbContext.Users.FindAsync(id);
            if (user is not null)
            {

                await _dbContext.Users
                    .Where(u => u.Id == id)
                    .ExecuteDeleteAsync();
            }

            return user;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public async Task<User?> GetUser(Guid id)
    {
        return await _dbContext.Users.FindAsync(id);
    }

    public async Task<User?> EditUser(SanitizedUser user)
    {
        User? foundUser = await _dbContext.Users.FindAsync(user.Id);

        if (foundUser == null)
        {
            return null;
        }

        foundUser.Username = user.Username;


        Console.WriteLine($"Updating user with ID: {user.Id}, new username: {user.Username}");

        await _dbContext.SaveChangesAsync();



        return foundUser;
    }

    public void Dispose()
    {

    }
}
