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
    public class ListMusicController : ControllerBase
    {
        private readonly IMusicQuerys _musicQuerys;

        public ListMusicController(IMusicQuerys musicQuerys)
        {
            _musicQuerys = musicQuerys;
        }
        // GET: api/ListMusic
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ListMusic/5
        [HttpGet("{id}", Name = "GetMusic")]
        public IList<MusicDto> GetListMusic(int id)
        {
            return _musicQuerys.GetListMusic(id);
        }

        // POST: api/ListMusic
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ListMusic/5
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
