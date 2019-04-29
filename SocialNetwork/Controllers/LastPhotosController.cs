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
    public class LastPhotosController : ControllerBase
    {
        private readonly IPhotoQuerys _lastPhotosQuery;

        public LastPhotosController(IPhotoQuerys lastPhotosQuery)
        {
            _lastPhotosQuery = lastPhotosQuery;
        }

        // GET: api/LastPhotos
        [HttpGet]
        public IList<PhotoDto> Get()
        {
            return _lastPhotosQuery.GetLastPhotos() ;
        }

        // GET: api/LastPhotos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LastPhotos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/LastPhotos/5
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
