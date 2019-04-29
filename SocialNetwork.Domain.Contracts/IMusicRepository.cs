using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.Domain.Contracts
{
    public interface IMusicRepository
    {
        IQueryable<Music> GetMusic();
    }
}
