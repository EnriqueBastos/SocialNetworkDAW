using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Commands.MusicCommands;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    

    
    [Route("api/[controller]")]
    [ApiController]
    public class AddMusicController : ControllerBase
    {
        private readonly IAddMusicCommandHandler _addMusicCommandHandler;

        public AddMusicController(IAddMusicCommandHandler addMusicCommandHandler)
        {
            _addMusicCommandHandler = addMusicCommandHandler;
        }
        // GET: api/AddMusic
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AddMusic/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AddMusic
        [HttpPost]
        public async Task Post(MusicDto music)
        {
            await _addMusicCommandHandler.Handler(music);
        }

        // PUT: api/AddMusic/5
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
