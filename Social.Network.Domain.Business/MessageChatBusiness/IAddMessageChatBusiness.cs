using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.MessageChatRepository
{
    public interface IAddMessageChatBusiness
    {
        Task AddChatMessage(MessageChatDto message);
    }
}