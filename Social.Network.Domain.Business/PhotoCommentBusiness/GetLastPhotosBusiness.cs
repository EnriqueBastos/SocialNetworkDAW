using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Contracts;

namespace SocialNetwork.Domain.Business
{
    public class GetLastPhotosBusiness : IGetLastPhotosBusiness
    {
        public readonly IUserPhotoRepository _photoRepository;

        public GetLastPhotosBusiness(IUserPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        public IList<PhotoDto> GetLastPhotos()
        {
            return _photoRepository
                .GetListPhoto()
                .OrderByDescending(photo => photo)
                .Select(photo =>
                new PhotoDto {
                    UserName = photo.User.Name,
                    ImageBytes = photo.Photo.ImageBytes,
                    Title = photo.Photo.Title,
                    UploadDateTime = photo.Photo.UpdateDateTime

                }).ToList();

            

          
                                                                            
        }
    }
}
