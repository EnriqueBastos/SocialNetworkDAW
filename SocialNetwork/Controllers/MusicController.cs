using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Commands.MusicCommands;
using SocialNetwork.Application.MusicQuerys;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    
    [ApiController]
    public class MusicController : ControllerBase
    {
        IMusicQuery _musicQuery;
        IAddMusicCommandHandler _addMusicCommandHandler;

        public MusicController(IMusicQuery musicQuery, IAddMusicCommandHandler addMusicCommandHandler)
        {
            _musicQuery = musicQuery ;
            _addMusicCommandHandler = addMusicCommandHandler;
        }

       
        [HttpGet("{id}", Name = "GetMusic")]
        [ActionName("getMusic")]
        public async Task<IList<MusicDto>> GetMusic(int id)
        {
            return await _musicQuery.GetListMusicByUserId(id);
        }

        // POST: api/GetMusic
        [HttpPost]
        [ActionName("AddMusic")]
        public async Task AddMusic([FromBody] MusicDto musicDto)
        {
            await _addMusicCommandHandler.Handler(musicDto);
        }

        
    }
}
