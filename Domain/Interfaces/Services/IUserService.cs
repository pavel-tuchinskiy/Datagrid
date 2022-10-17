using Domain.DTOs;
using Domain.DTOs.User;
using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<PagedList<UserDTO>> GetUsers(RequestParametersDTO parameters);
        Task CreateUser(UserCreateDTO userDTO);
    }
}
