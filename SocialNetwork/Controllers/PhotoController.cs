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
    public class PhotoController : ControllerBase
    {
        private readonly IUserPhotoQuery _photoQuerys;

        public PhotoController(IUserPhotoQuery photoQuerys)
        {
            _photoQuerys = photoQuerys;
        }
        // GET: api/Photo
        [HttpGet]
        public void Get()
        {
            
        }

        // GET: api/Photo/5
        [HttpGet("{id}", Name = "GetPhotoById")]
        public PhotoDto Get(int id)
        {
            return _photoQuerys.GetPhotoByPhotoId(id);
        }

        // POST: api/Photo
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
