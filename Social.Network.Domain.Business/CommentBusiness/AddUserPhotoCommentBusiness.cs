using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.CommentBusiness
{
    public class AddUserPhotoCommentBusiness : IAddUserPhotoCommentBusiness
    {
        private readonly IUserPhotoCommentRepository _commentRepository;

        public AddUserPhotoCommentBusiness(IUserPhotoCommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void AddUserPhotoComment(CommentDto comment)
        {
            _commentRepository.AddUserPhotoComment(new UserPhotoComment
            {
                UserId = comment.UserId,
                UserPhotoId = comment.PhotoId,
                CommentText = comment.CommentText
            });
        }
    }
}
