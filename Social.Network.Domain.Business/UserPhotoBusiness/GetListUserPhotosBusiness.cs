using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Business.ContactBusiness;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public class GetListUserPhotosBusiness : IGetListUserPhotosBusiness
    {
        public readonly IUserPhotoRepository _photoRepository;

        public readonly IContactRepository _contactRepository;

        public readonly IGetContactBusiness _getContactBusiness;

        public GetListUserPhotosBusiness(IUserPhotoRepository photoRepository, IContactRepository contactRepository, IGetContactBusiness getContactBusiness)
        {
            _photoRepository = photoRepository;

            _contactRepository = contactRepository;

            _getContactBusiness = getContactBusiness;
        }
        public IList<GetPhotoDto> GetLastPhotosContacts(int userId)
        {
            IList<GetPhotoDto> listGetPhotoDto = new List<GetPhotoDto>();
            var contactsId = _getContactBusiness.GetListFriendIdByUserId(userId).ToList();
            contactsId.Add(userId);
            contactsId.ForEach(id =>
                    GetListPhotosByUserId(id)
                    .Result
                    .ToList()
                    .ForEach(photo =>
                        listGetPhotoDto.Add(photo)
                        )
                );
           

            return listGetPhotoDto
                .OrderByDescending(photo => photo.UploadDateTime)
                .ToList();


        }

        public async Task<IList<GetPhotoDto>> GetListPhotosByUserId(int userId)
        {
            return await  _photoRepository
                .GetUserPhoto()
                .OrderByDescending(photo => photo)
                .Where(userPhoto => userPhoto.UserId == userId)
                .Select(photo =>
                new GetPhotoDto {
                    UserPhotoId = photo.Id,
                    UserName = photo.User.Name,
                    ImageBytes = photo.Photo.ImageBytes,
                    Title = photo.Photo.Title,
                    UploadDateTime = photo.Photo.UpdateDateTime,
                    Likes = photo.Photo.Likes,
                    DisLikes = photo.Photo.Dislikes,
                    UserId = photo.UserId
                    

                })
                .ToListAsync();
            
        }
    }
}
