using SocialNetwork.Domain.Business.PhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ChatCommands
{
    public class EditPhotoCommandHandler
    {
        private readonly IEditPhotoBusiness _editPhotoBusiness;

        private readonly IPhotoRepository _photoRepository;

        public EditPhotoCommandHandler(IEditPhotoBusiness editPhotoBusiness, IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;

            _editPhotoBusiness = editPhotoBusiness;
        }

        public async Task Handler(GetPhotoDto photoDto)
        {
            _editPhotoBusiness.EditPhoto(photoDto);

            await _photoRepository.UnitOfWork.Save();
        }
    }
}
