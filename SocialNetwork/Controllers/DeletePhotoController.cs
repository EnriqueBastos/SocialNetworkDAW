using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeletePhotoController : ControllerBase
    {
        private readonly IUserPhotoQuery _photoQuerys;

        public DeletePhotoController(IUserPhotoQuery photoQuerys)
        {
            _photoQuerys = photoQuerys;
        }
        // GET: api/DeletePhoto
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DeletePhoto/5
        [HttpGet("{id}", Name = "DeletePhoto")]
        public void Get(int id)
        {
            _photoQuerys.DeletePhoto(id);
        }

        // POST: api/DeletePhoto
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/DeletePhoto/5
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
