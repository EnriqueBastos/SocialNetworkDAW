using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddUserController : ControllerBase
    {
        private readonly IUserQuery _userQuery;

        public AddUserController(IUserQuery userQuery)
        {
            _userQuery = userQuery;
        }
        // GET: api/AddUser
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AddUser/5
        [HttpGet("{id}", Name = "AddUser")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AddUser
        [HttpPost]
        public void Post(UserDto user)
        {
            _userQuery.AddUser(user);
        }

        // PUT: api/AddUser/5
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
