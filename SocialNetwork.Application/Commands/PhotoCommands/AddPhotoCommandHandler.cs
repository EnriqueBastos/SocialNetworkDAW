using SocialNetwork.Domain.Business.PhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.PhotoCommands
{
    public class AddPhotoCommandHandler : IAddPhotoCommandHandler
    {
        private readonly IPhotoRepository _photoRepository;
        private readonly IAddPhotoBusiness _addPhotoBusiness;

        public AddPhotoCommandHandler(IPhotoRepository photoRepository , IAddPhotoBusiness addPhotoBusiness)
        {
            _photoRepository = photoRepository;
            _addPhotoBusiness = addPhotoBusiness;
        }

        public async Task Handler(AddPhotoDto photo)
        {
            _addPhotoBusiness.AddPhoto(photo);

            await _photoRepository.UnitOfWork.Save();
        }


    }
}
