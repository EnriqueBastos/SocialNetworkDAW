using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.CommentBusiness
{
    public class AddUserPhotoCommentBusiness : IAddUserPhotoCommentBusiness
    {
        private readonly IUserPhotoCommentRepository _commentRepository;

        public AddUserPhotoCommentBusiness(IUserPhotoCommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task AddUserPhotoComment(CommentDto comment)
        {
            _commentRepository.AddUserPhotoComment(new UserPhotoComment
            {
                UserId = comment.UserId,
                UserPhotoId = comment.UserPhotoId,
                CommentText = comment.CommentText
            });

            await _commentRepository.UnitOfWork.Save();
        }
    }
}
