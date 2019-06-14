using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public class GetUserPhotoBusiness : IGetUserPhotoBusiness
    {
        private readonly IUserPhotoRepository _userPhotoRepository;

        private readonly IGetUserPhotoCommentsBusiness _getUserPhotoCommentsBusiness;

        public GetUserPhotoBusiness(IUserPhotoRepository userPhotoRepository , IGetUserPhotoCommentsBusiness getUserPhotoCommentsBusiness)
        {
            _userPhotoRepository = userPhotoRepository;
            _getUserPhotoCommentsBusiness = getUserPhotoCommentsBusiness;
        }

        public async Task<GetPhotoDto> GetPhotoDetailsDtoByPhotoId(int PhotoId)
        {
             return await _userPhotoRepository
                .GetUserPhoto()
                .Select(photo => new GetPhotoDto
                {
                    UserName = photo.User.Name,
                    ImageBytes = photo.Photo.ImageBytes,
                    Title = photo.Photo.Title,
                    UploadDateTime = photo.Photo.UpdateDateTime
                })
                .FirstOrDefaultAsync(photo =>
                photo.UserPhotoId == PhotoId
               );
            
        }

        public async Task<UserPhoto> GetUserPhotoByPhotoId(int PhotoId)
        {
            return await _userPhotoRepository
                .GetUserPhoto()
                .FirstOrDefaultAsync(userPhoto =>
                userPhoto.Photo.Id == PhotoId
               );
        }

        public async  Task<UserPhoto> GetUserPhotoByUserPhotoId(int userPhotoId)
        {
            var k = await _userPhotoRepository
                .GetUserPhoto()
                .Include(userPhoto => userPhoto.User)
                .Include(userPhoto => userPhoto.Photo)
                .Select(userPhoto =>userPhoto)
                .FirstOrDefaultAsync(userPhoto => userPhoto.Id == userPhotoId);

            return k;
            
                
               

        }

        public async  Task<GetUserPhotoInfoDto> GetUserPhotoInfoDtoByPhotoId(int userPhotoId)
        {
            var comments = await _getUserPhotoCommentsBusiness
                            .GetCommentsByUserPhotoId(userPhotoId);


            var photo = await GetUserPhotoByUserPhotoId(userPhotoId);

            return new GetUserPhotoInfoDto
            {
                UserPhotoId = photo.Id,
                UserName = photo.User.Name,
                UserId = photo.User.Id,
                PhotoId = photo.PhotoId,
                ImageBytes = photo.Photo.ImageBytes,
                Title = photo.Photo.Title,
                UploadDateTime = photo.Photo.UpdateDateTime,
                Likes = photo.Photo.Likes,
                Comments = comments
            };
                                    
                                        
                                    
                
                
                
        }
    }
}
