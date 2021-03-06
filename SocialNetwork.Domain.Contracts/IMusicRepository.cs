﻿using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IMusicRepository : IRepository
    {
        IQueryable<Music> GetMusic();

        void DeleteMusic(Music music);

        Task AddMusic(Music music);
    }
}
