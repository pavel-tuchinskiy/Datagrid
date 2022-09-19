using DataAccess.Data;
using Domain.DTOs;
using Domain.DTOs.User;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces.Repositories;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class UsersRepository : IUserRepository
    {
        private readonly GridDbContext _context;

        public UsersRepository(GridDbContext context)
        {
            _context = context;
        }

        public async Task CreateUser(UserCreateDTO userDTO)
        {
            var user = new User()
            {
                Phone = userDTO.Phone,
                LastName = userDTO.LastName,
                FirstName = userDTO.FirstName
            };

            _context.Users.Add(user);
            var saveResult = await _context.SaveChangesAsync();

            if (saveResult == 0)
                throw new ResponseException("Something went wrong while saving entity", nameof(CreateUser), ErrorCodes.Err500);
        }

        public async Task<PagedList<UserDTO>> GetUsers(RequestParametersDTO parameters)
        {
            if (parameters.GlobalSearchTerm != null)
            {
                var users = _context.Users.Where(x => x.FirstName.Contains(parameters.GlobalSearchTerm) || x.LastName.Contains(parameters.GlobalSearchTerm))
                .Select(x => new UserDTO
                {
                            Id = x.Id,
                            FullName = $"{x.FirstName} {x.LastName}"
                })
                  .AsQueryable();

                var userList = await PagedList<UserDTO>.ToPagedListAsync(users, parameters.PageNumber, parameters.PageSize);

                if(userList.Items.Count > 0)
                {
                    return userList;
                }
                else
                {
                    throw new ResponseException("Can't find this user", nameof(GetUsers), ErrorCodes.Err404U);
                }
            }
            else
            {
                var users = _context.Users.Select(x => new UserDTO
                {
                    Id = x.Id,
                    FullName = $"{x.FirstName} {x.LastName}"
                })
                  .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                  .Take(parameters.PageSize)
                  .AsQueryable();

                return await PagedList<UserDTO>.ToPagedListAsync(users, parameters.PageNumber, parameters.PageSize);
            }
        }
    }
}
