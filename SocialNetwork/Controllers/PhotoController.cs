using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Commands.PhotoCommands;
using System.Web.Http;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        IAddPhotoCommandHandler _addPhotoCommandHandler;
        public PhotoController(IAddPhotoCommandHandler addPhotoCommandHandler)
        {
            _addPhotoCommandHandler = addPhotoCommandHandler;
        }
        // GET: api/Photo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Photo/5
        [HttpGet("{id}", Name = "GetPhotos")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Photo
        [HttpPost]
        [ActionName("UploadPhoto")]

        public async Task UploadPhoto([FromBody] PhotoDto photo)
        {

            await _addPhotoCommandHandler.Handler(photo);
        }

        

        // PUT: api/Photo/5
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
