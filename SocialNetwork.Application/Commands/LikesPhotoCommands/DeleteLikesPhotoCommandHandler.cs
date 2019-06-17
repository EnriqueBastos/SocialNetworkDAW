using SocialNetwork.Domain.Business.LikesPhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos.PhotoDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.LikesPhotoCommands
{
    public class DeleteLikesPhotoCommandHandler : IDeleteLikesPhotoCommandHandler
    {
        private readonly IDeleteLikesPhotoBusiness _deleteLikesPhotoBusiness;
        private readonly ILikesPhotoRepository _likesRepository;
        public DeleteLikesPhotoCommandHandler(IDeleteLikesPhotoBusiness deleteLikesPhotoBusiness , ILikesPhotoRepository likesPhotoRepository)
        {
            _deleteLikesPhotoBusiness = deleteLikesPhotoBusiness;
            _likesRepository = likesPhotoRepository;
        }


        public async Task Handler(LikesPhotoDto likesPhotoDto)
        {
            await _deleteLikesPhotoBusiness.DeleteLikesPhotoByLikesPhotoDto(likesPhotoDto);
            await _likesRepository.UnitOfWork.Save();
        }
    }
}
