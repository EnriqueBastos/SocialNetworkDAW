using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.ChatBusiness
{
    public interface IDeleteChatBusiness
    {
        void DeleteChat(ChatDto chatDto);
    }
}
