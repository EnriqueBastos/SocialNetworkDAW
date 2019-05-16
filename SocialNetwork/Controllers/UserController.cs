using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application;
using SocialNetwork.Application.Commands;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAddUserCommandHandler _addUserCommandHandler;

        private readonly IUserQuery _userQuery;

        public UserController(IAddUserCommandHandler addUserCommandHandler, IUserQuery userQuery )
        {
            _addUserCommandHandler = addUserCommandHandler;
            _userQuery = userQuery;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUsers")]
        public int GetUserId(UserLoginDto loginDto)
        {
            return  _userQuery.GetUserIdByLoginDto(loginDto);
        }

        // POST: api/User
        [HttpPost]
        public async Task Post(UserDto userDto)
        {
            await _addUserCommandHandler.Handler(userDto);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
