using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Commands.UserPhotoCommentCommands;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserPhotoCommentController : ControllerBase
    {
        private readonly IAddUserPhotoCommentCommandHandler _addUserPhotoCommentCommandHandler;

        public UserPhotoCommentController(IAddUserPhotoCommentCommandHandler addUserPhotoCommentCommandHandler)
        {
            _addUserPhotoCommentCommandHandler = addUserPhotoCommentCommandHandler;
        }
        // GET: api/UserPhotoComment
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserPhotoComment/5
        [HttpGet("{id}", Name = "GetComments")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserPhotoComment/addcomment
        [HttpPost]
        [ActionName("addComment")]
        public async Task AddUserPhotoComment([FromBody] CommentDto comment)
        {
            await _addUserPhotoCommentCommandHandler.Handler(comment);
        }

        // PUT: api/UserPhotoComment/5
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
