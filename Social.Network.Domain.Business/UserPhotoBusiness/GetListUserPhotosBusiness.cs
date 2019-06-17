using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Business.ContactBusiness;
using System.Threading.Tasks;
using SocialNetwork.Domain.Business.LikesPhotoBusiness;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public class GetListUserPhotosBusiness : IGetListUserPhotosBusiness
    {
        private readonly IUserPhotoRepository _photoRepository;

        private readonly IContactRepository _contactRepository;

        private readonly IGetContactBusiness _getContactBusiness;

        private readonly IGetLikesPhotoBusiness _getLikesPhotoBusiness;



        public GetListUserPhotosBusiness(
            IUserPhotoRepository photoRepository,
            IContactRepository contactRepository,
            IGetContactBusiness getContactBusiness,
            IGetLikesPhotoBusiness getLikesPhotoBusiness
            )
        {
            _photoRepository = photoRepository;
            _contactRepository = contactRepository;
            _getContactBusiness = getContactBusiness;
            _getLikesPhotoBusiness = getLikesPhotoBusiness;
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
            IList<GetPhotoDto> getPhotoDtos = new List<GetPhotoDto>();
            var userPhotos = await _photoRepository
                .GetUserPhoto()
                .Include(userphoto => userphoto.Photo)
                .Include(userphoto => userphoto.User)
                .OrderByDescending(photo => photo)
                .Where(userPhoto => userPhoto.UserId == userId)
                .ToListAsync();
            foreach(Entities.UserPhoto userPhoto in userPhotos)
            {
                var likesPhotoDtos = await _getLikesPhotoBusiness.GetLikesPhotoDtosByUserPhotoId(userPhoto.Id);
                getPhotoDtos.Add(new GetPhotoDto
                {
                    UserPhotoId = userPhoto.Id,
                    UserName = userPhoto.User.Name,
                    ImageBytes = userPhoto.Photo.ImageBytes,
                    Title = userPhoto.Photo.Title,
                    UploadDateTime = userPhoto.Photo.UpdateDateTime,
                    UserId = userPhoto.UserId,
                    LikesPhotoDtos = likesPhotoDtos
                });
            }
            return getPhotoDtos;
        }
    }
}
