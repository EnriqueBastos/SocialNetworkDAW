using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Commands.MusicCommands;
using SocialNetwork.Application.MusicQuerys;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.MusicDtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    
    [ApiController]
    public class MusicController : ControllerBase
    {
        IMusicQuery _musicQuery;
        IAddMusicCommandHandler _addMusicCommandHandler;
        IDeleteMusicCommandHandler _deleteMusicCommandHandler;

        public MusicController(
            IMusicQuery musicQuery,
            IAddMusicCommandHandler addMusicCommandHandler,
            IDeleteMusicCommandHandler deleteMusicCommandHandler
            )
        {
            _musicQuery = musicQuery ;
            _addMusicCommandHandler = addMusicCommandHandler;
            _deleteMusicCommandHandler = deleteMusicCommandHandler;
        }

       
        [HttpGet("{id}", Name = "GetMusic")]
        [ActionName("getMusic")]
        public async Task<ListMusicDto> GetMusic(int id)
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

        [HttpPost]
        [ActionName("DeleteMusic")]
        public async Task DeleteMusic([FromBody] MusicDto musicDto)
        {
            await _deleteMusicCommandHandler.Handler(musicDto.MusicId);
        }



        
    }
}
