using Domain.DTOs;
using Domain.DTOs.User;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ReturnHttpResult> Get([FromQuery] RequestParameters parameters)
        {
            var parmetersParsed = new RequestParametersDTO()
            {
                GlobalSearchTerm = parameters.GlobalSearchTerm,
                PageNumber = parameters.PageNumber,
                PageSize = parameters.PageSize
            };

            var users = await _userService.GetUsers(parmetersParsed);

            return new ReturnHttpResult(200, users);
        }

        [HttpPost]
        public async Task<ReturnHttpResult> Post(UserCreateDTO userCreateDTO)
        {
            await _userService.CreateUser(userCreateDTO);

            return new ReturnHttpResult(201);
        }
    }
}
