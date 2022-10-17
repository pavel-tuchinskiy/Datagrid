using DataAccess.Data;
using DataAccess.Repositories;
using Domain.DTOs;
using Domain.DTOs.User;
using Domain.Interfaces.Data;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(GridDbContext efContext, IGridDbMongoContext mongoContext)
        {
            var resolver = new RepositoryResolver(efContext, mongoContext);
            _userRepository = resolver.GetUserRepository(RepositoryProviders.Mongo);
        }

        public async Task<PagedList<UserDTO>> GetUsers(RequestParametersDTO parameters)
        {
            var users = await _userRepository.GetUsers(parameters);

            return users;
        }

        public async Task CreateUser(UserCreateDTO userDTO)
        {
            await _userRepository.CreateUser(userDTO);
        }
    }
}
