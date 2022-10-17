using Domain.DTOs;
using Domain.DTOs.User;
using Domain.Entities;
using Domain.Interfaces.Data;
using Domain.Interfaces.Repositories;
using Domain.Models;
using MongoDB.Driver;

namespace DataAccess.Repositories.Mongo
{
    public class UsersRepository : IUserRepository
    {
        private readonly IGridDbMongoContext _context;
        private readonly IMongoCollection<User> _usersCollection;

        public UsersRepository(IGridDbMongoContext context)
        {
            _context = context;
            _usersCollection = _context.GetCollection<User>("Users");
        }

        public async Task CreateUser(UserCreateDTO userDTO)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Phone = userDTO.Phone,
            };

            await _usersCollection.InsertOneAsync(user);
        }

        public async Task<PagedList<UserDTO>> GetUsers(RequestParametersDTO parameters)
        {
            var projection = Builders<User>.Projection.Expression(u => new UserDTO
            {
                Id = u.Id,
                FullName = $"{u.FirstName} {u.LastName}"
            });

            FilterDefinition<User> filter = null;

            if (!string.IsNullOrEmpty(parameters.GlobalSearchTerm))
                filter = Builders<User>.Filter.Where(u => u.FirstName.Contains(parameters.GlobalSearchTerm)
                    || u.LastName.Contains(parameters.GlobalSearchTerm));
            else
                filter = Builders<User>.Filter.Empty;

            var users = _usersCollection.Find(filter).Project(projection);

            return await PagedList<UserDTO>.ToPagedListAsync<User, UserDTO>(users, parameters.PageNumber, parameters.PageSize);
        }
    }
}
