using SocialNetwork.Domain.Business.CommentBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.CommentCommands
{
    public class DeleteCommentCommandHandler : IDeleteCommentCommandHandler
    {
        private readonly IDeleteUserPhotoCommentBusiness _deleteUserPhotoCommentBusiness;
        private readonly IUserPhotoCommentRepository _userPhotoCommentRepository;

        public DeleteCommentCommandHandler(IDeleteUserPhotoCommentBusiness deleteUserPhotoCommentBusiness, IUserPhotoCommentRepository userPhotoCommentRepository)
        {
            _userPhotoCommentRepository = userPhotoCommentRepository;
            _deleteUserPhotoCommentBusiness = deleteUserPhotoCommentBusiness;
        }

        public async Task Handler(CommentDto comment)
        {
            _deleteUserPhotoCommentBusiness.DeleteUserPhotoCommentByCommentDto(comment);
            await _userPhotoCommentRepository.UnitOfWork.Save();
        }
    }
}
