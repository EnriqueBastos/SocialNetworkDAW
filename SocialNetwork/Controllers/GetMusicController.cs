using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.MusicQuerys;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMusicController : ControllerBase
    {
        IMusicQuery _musicQuery;

        public GetMusicController(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery ;
        }
        // GET: api/GetMusic
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GetMusic/5
        [HttpGet("{id}", Name = "GetMusic")]
        public IList<MusicDto> Get(int id)
        {
            return _musicQuery.GetListMusicByUserId(id);
        }

        // POST: api/GetMusic
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GetMusic/5
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
