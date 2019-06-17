using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos.PhotoDtos;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.LikesPhotoBusiness
{
    public class AddLikesPhotoBusiness : IAddLikesPhotoBusiness
    {
        private readonly ILikesPhotoRepository _likesPhotoRepository;
        public AddLikesPhotoBusiness(ILikesPhotoRepository likesPhotoRepository)
        {
            _likesPhotoRepository = likesPhotoRepository;
        }

        public async Task AddLikesPhoto(LikesPhotoDto likesPhotoDto)
        {
            await _likesPhotoRepository.AddLikesPhoto(new LikesPhoto
            {
                UserId = likesPhotoDto.UserId,
                UserPhotoId = likesPhotoDto.UserPhotoId
            });

        }
    }
}
