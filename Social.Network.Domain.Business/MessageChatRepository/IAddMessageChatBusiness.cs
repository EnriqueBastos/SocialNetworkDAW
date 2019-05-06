using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.MessageChatRepository
{
    public interface IAddMessageChatBusiness
    {
        void AddChatMessage(MessageChatDto message);
    }
}