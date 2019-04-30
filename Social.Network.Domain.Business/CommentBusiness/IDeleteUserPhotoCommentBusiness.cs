using SocialNetwork.Domain.Dtos;


namespace SocialNetwork.Domain.Business.CommentBusiness
{
    public interface IDeleteUserPhotoCommentBusiness
    {
         void DeleteUserPhotoCommentByCommentDto(CommentDto comment);
    }
}
