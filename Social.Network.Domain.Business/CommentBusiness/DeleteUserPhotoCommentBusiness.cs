using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.CommentBusiness
{
    public class DeleteUserPhotoCommentBusiness : IDeleteUserPhotoCommentBusiness
    {
        private readonly IUserPhotoCommentRepository _commentRepository;

        public DeleteUserPhotoCommentBusiness(IUserPhotoCommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void DeleteUserPhotoCommentByCommentDto(CommentDto comment)
        {
            _commentRepository.DeleteUserPhotoComment(new UserPhotoComment
            {
                Id = comment.Id,
                UserId = comment.UserId,
                UserPhotoId = comment.PhotoId,
                CommentText = comment.CommentText
            });
        }
    }
}
