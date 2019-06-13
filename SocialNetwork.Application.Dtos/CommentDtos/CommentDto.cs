

namespace SocialNetwork.Domain.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string CommentText { get; set; }

        public int UserPhotoId { get; set; }
    }
}
