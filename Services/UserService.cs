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
        throw new NotImplementedException();
    }

    public async Task<SanitizedUser> CreateUser(CreateUser user)
    {
        throw new NotImplementedException();
    }

    public async Task<SanitizedUser?> EditUser(SanitizedUser user)
    {
        throw new NotImplementedException();
    }

    public async Task<SanitizedUser?> DeleteUser(SanitizedUser user)
    {
        throw new NotImplementedException();
    }
}
