using EFCoreAssignment.DTOs;
using EFCoreAssignment.Models;

namespace EFCoreAssignment.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(UserDto user);
        void UpdateUser(int id, UserDto user);
        void DeleteUser(int id);
    }

}
