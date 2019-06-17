using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application;
using SocialNetwork.Application.Commands;
using SocialNetwork.Application.Commands.UserCommands;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.UserDtos;

namespace SocialNetwork.Controllers
{
   
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAddUserCommandHandler _addUserCommandHandler;

        private readonly IUserQuery _userQuery;

        private readonly IEditUserCommandHandler _editUserCommandHandler;

        private readonly IDeleteUserCommandHandler _deleteUserCommandHandler;

        public UserController(
            IAddUserCommandHandler addUserCommandHandler,
            IUserQuery userQuery ,
            IEditUserCommandHandler editUserCommandHandler,
            IDeleteUserCommandHandler deleteUserCommandHandler
            )
        {
            _addUserCommandHandler = addUserCommandHandler;
            _userQuery = userQuery;
            _editUserCommandHandler = editUserCommandHandler;
            _deleteUserCommandHandler = deleteUserCommandHandler;
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
        public async Task<GetLoginDto> GetLoginDto(UserLoginDto loginDto)
        {
            return await  _userQuery.GetLoginDtoByUserLoginDto(loginDto);
        }

        // POST: api/User
        [HttpPost]
        [ActionName("AddUser")]
        public async Task<GetLoginDto> AddUser(UserDto userDto)
        {
            return await  _addUserCommandHandler.Handler(userDto);
        }

        [HttpPost]
        [ActionName("EditUser")]

        public async Task EditUser(SetUserDto profileDetailsDto)
        {
            await _editUserCommandHandler.Handler(profileDetailsDto);
        }

        [HttpPost]
        [ActionName("DeleteUser")]
        public async Task DeleteUser(UserDto user)
        {
            await _deleteUserCommandHandler.Handler(user.Id);
        }


 
    }
}
