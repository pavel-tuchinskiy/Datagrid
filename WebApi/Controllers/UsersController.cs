using Domain.DTOs.User;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _usersRepository;

        public UsersController(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpGet]
        public async Task<ReturnHttpResult> Get([FromQuery] UsersRequestParameters parameters)
        {
            var parmetersParsed = RequestParametersParser<UsersRequestParameters>.ParseParameters(parameters);
            var users = await _usersRepository.GetUsers(parmetersParsed);

            return new ReturnHttpResult(200, users);
        }

        [HttpPost]
        public async Task<ReturnHttpResult> Post(UserCreateDTO userCreateDTO)
        {
            await _usersRepository.CreateUser(userCreateDTO);

            return new ReturnHttpResult(201);
        }
    }
}
