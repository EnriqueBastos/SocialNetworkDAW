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

        public DeleteUserPhotoCommandHandler(IDeleteUserPhotoBusiness deleteUserPhotoBusiness , IUserPhotoRepository userPhotoRepository)
        {
            _deleteUserPhotoBusiness = deleteUserPhotoBusiness;
            _userPhotoRepository = userPhotoRepository;
        }

        public async Task DeleteUserPhotoByPhotoId(int photoId)
        {
            await _deleteUserPhotoBusiness.DeletePhotoByPhotoId(photoId);
            await _userPhotoRepository.UnitOfWork.Save();
        }
    }
}
