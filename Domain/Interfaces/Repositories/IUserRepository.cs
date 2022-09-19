using Domain.DTOs;
using Domain.DTOs.User;
using Domain.Models;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<PagedList<UserDTO>> GetUsers(RequestParametersDTO parameters);
        Task CreateUser(UserCreateDTO userDTO);
    }
}
