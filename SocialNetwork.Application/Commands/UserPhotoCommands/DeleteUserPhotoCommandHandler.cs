using SocialNetwork.Domain.Business.CommentBusiness;
using SocialNetwork.Domain.Business.UserPhotoBusiness;
using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserPhotoCommands
{
    public class DeleteUserPhotoCommandHandler : IDeleteUserPhotoCommandHandler
    {
        private readonly IDeleteUserPhotoBusiness _deleteUserPhotoBusiness;
        private readonly IUserPhotoRepository _userPhotoRepository;
        private readonly IDeleteUserPhotoCommentBusiness _deleteUserPhotoCommentBusiness;

        public DeleteUserPhotoCommandHandler(
            IDeleteUserPhotoBusiness deleteUserPhotoBusiness ,
            IUserPhotoRepository userPhotoRepository,
            IDeleteUserPhotoCommentBusiness deleteUserPhotoCommentBusiness
            )
        {
            _deleteUserPhotoBusiness = deleteUserPhotoBusiness;
            _userPhotoRepository = userPhotoRepository;
            _deleteUserPhotoCommentBusiness = deleteUserPhotoCommentBusiness;
        }

        public async Task DeleteUserPhotoByPhotoId(int photoId)
        {
            await _deleteUserPhotoCommentBusiness.DeleteUserPhotoCommentsByPhotoId(photoId);
            await _userPhotoRepository.UnitOfWork.Save();
            await _deleteUserPhotoBusiness.DeleteUserPhotoByPhotoId(photoId);
            await _userPhotoRepository.UnitOfWork.Save();
        }
    }
}
