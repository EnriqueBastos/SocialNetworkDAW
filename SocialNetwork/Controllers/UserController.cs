using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application;
using SocialNetwork.Application.Commands;
using SocialNetwork.Application.Commands.UserCommands;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
   
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAddUserCommandHandler _addUserCommandHandler;

        private readonly IUserQuery _userQuery;

        private readonly IEditUserCommandHandler _editUserCommandHandler;

        public UserController(IAddUserCommandHandler addUserCommandHandler, IUserQuery userQuery , IEditUserCommandHandler editUserCommandHandler )
        {
            _addUserCommandHandler = addUserCommandHandler;
            _userQuery = userQuery;
            _editUserCommandHandler = editUserCommandHandler;
        }


        // GET: api/User/GetProfile/1

        [HttpGet("{userId}", Name = "GetProfile")]
        [ActionName("GetProfile")]
        public async Task<ProfileDetailsDto> GetProfileDto(int userId)
        {
            return await _userQuery.GetProfileDetailsDtoByUserId(userId);
        }

        [HttpPost]
        [ActionName("GetUserId")]
        public async Task<int> GetUserId(UserLoginDto loginDto)
        {
            return await  _userQuery.GetUserIdByLoginDto(loginDto);
        }

        // POST: api/User
        [HttpPost]
        [ActionName("AddUser")]
        public async Task<int> AddUser(UserDto userDto)
        {
            return await  _addUserCommandHandler.Handler(userDto);
        }

        [HttpPost]
        [ActionName("EditUser")]

        public async Task EditUser(SetUserDto profileDetailsDto)
        {
            await _editUserCommandHandler.Handler(profileDetailsDto);
        }


 
    }
}
