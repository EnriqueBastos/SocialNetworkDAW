
namespace SocialNetwork.Domain.Dtos.ChatDtos
{
    public class ChatDto
    {
        public string UserName { get; set; }

        public byte[] PhotoProfile { get; set; }

        public int ChatId { get; set; }

        public int CountIsNotSeen { get; set; }
    }
}
