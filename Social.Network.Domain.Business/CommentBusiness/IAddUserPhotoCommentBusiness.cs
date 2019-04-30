using SocialNetwork.Domain.Dtos;


namespace SocialNetwork.Domain.Business.CommentBusiness
{
    public interface IAddUserPhotoCommentBusiness
    {
        void AddUserPhotoComment(CommentDto comment);
    }
}
