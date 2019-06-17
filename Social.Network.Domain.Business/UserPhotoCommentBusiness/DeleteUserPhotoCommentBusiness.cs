using SocialNetwork.Domain.Business.UserPhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.CommentBusiness
{
    public class DeleteUserPhotoCommentBusiness : IDeleteUserPhotoCommentBusiness
    {
        private readonly IUserPhotoCommentRepository _commentRepository;
        private readonly IGetUserPhotoCommentsBusiness _getUserPhotoCommentsBusiness;
        private readonly IGetUserPhotoBusiness _getUserPhotoBusiness;

        public DeleteUserPhotoCommentBusiness(
            IUserPhotoCommentRepository commentRepository ,
            IGetUserPhotoCommentsBusiness getUserPhotoCommentsBusiness ,
            IGetUserPhotoBusiness getUserPhotoBusiness
            )
        {
            _commentRepository = commentRepository;
            _getUserPhotoCommentsBusiness = getUserPhotoCommentsBusiness;
            _getUserPhotoBusiness = getUserPhotoBusiness;
        }

        public async Task DeleteUserPhotoCommentsByPhotoId(int photoId)
        {
            var userPhoto = await  _getUserPhotoBusiness.GetUserPhotoByPhotoId(photoId);
            var listComments = await _getUserPhotoCommentsBusiness.GetUserPhotoCommentsByUserPhotoId(userPhoto.Id);
            foreach(Entities.UserPhotoComment comment in listComments)
            {
                _commentRepository.DeleteUserPhotoComment(comment);
            }
            
            
        }
    }
}
