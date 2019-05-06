using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Business.GroupChatBusiness
{
    public class DeleteGroupChatBusiness
    {
        private readonly IGroupChatRepository _groupChatRepository;

        public DeleteGroupChatBusiness(IGroupChatRepository groupChatRepository)
        {
            _groupChatRepository = groupChatRepository;
        }


    }
}
