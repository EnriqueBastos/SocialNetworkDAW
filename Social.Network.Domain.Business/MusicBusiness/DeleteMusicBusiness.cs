using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.MusicBusiness
{
    public class DeleteMusicBusiness : IDeleteMusicBusiness
    {
        private readonly IMusicRepository _musicRepository;

        public DeleteMusicBusiness(IMusicRepository musicRepository)
        {

            _musicRepository = musicRepository;
        }

        public void DeleteMusicByMusicId(int musicId)
        {
            var musicDto = _musicRepository
                .GetMusic()
                .FirstOrDefault(music =>
                music.Id == musicId
                );
            _musicRepository.DeleteMusic(musicDto);
            
        }
    }
}
