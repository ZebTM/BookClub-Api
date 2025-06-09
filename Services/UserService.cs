using BookClub.Models;
using BookClub.Repository;

namespace BookClub.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }



    public async Task<IEnumerable<SanitizedUser>> GetAllUsers()
    {
        return await _userRepository.GetAllUsers();
    }

    public async Task<SanitizedUser?> GetUserById(Guid id)
    {
        User? user = await _userRepository.GetUser(id);

        Console.WriteLine("User not found {0}", id);
        if (user == null)
        {
            Console.WriteLine("User not found {0}", id);
            return null;
        }

        return new SanitizedUser(user);
    }

    public async Task<SanitizedUser> CreateUser(User CreatedUser)
    {

        CreatedUser = await _userRepository.InsertUser(CreatedUser);

        return new SanitizedUser(CreatedUser);
    }

    public async Task<SanitizedUser?> EditUser(SanitizedUser user)
    {

        User? foundUser = await _userRepository.EditUser(user);

        if (foundUser == null)
        {
            return null;
        }

        return new SanitizedUser(foundUser);
    }

    public async Task<SanitizedUser?> DeleteUser(Guid id)
    {
        User? userToBeDeleted = await _userRepository.DeleteUser(id);

        if (userToBeDeleted == null)
        {
            return null;
        }


        return new SanitizedUser(userToBeDeleted);

    }

    public async Task<User?> GetUserByUsername(String username)
    {
        return await _userRepository.GetUserByUsername(username);
    }
}
