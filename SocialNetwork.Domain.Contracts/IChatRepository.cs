using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Contracts
{
    public interface IChatRepository : IRepository
    {
        void AddChat(Chat chat);

        void DeleteChat(Chat chat);

    }
}
