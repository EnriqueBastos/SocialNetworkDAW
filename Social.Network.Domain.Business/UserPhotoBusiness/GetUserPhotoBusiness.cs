using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Business.LikesPhotoBusiness;
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
        private readonly IGetLikesPhotoBusiness _getLikesPhotoBusiness;

        public GetUserPhotoBusiness(
            IUserPhotoRepository userPhotoRepository ,
            IGetUserPhotoCommentsBusiness getUserPhotoCommentsBusiness,
            IGetLikesPhotoBusiness getLikesPhotoBusiness
            )
        {
            _userPhotoRepository = userPhotoRepository;
            _getUserPhotoCommentsBusiness = getUserPhotoCommentsBusiness;
            _getLikesPhotoBusiness = getLikesPhotoBusiness;
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
            var userPhoto = await _userPhotoRepository
                .GetUserPhoto()
                .Include(x => x.User)
                .Include(x => x.Photo)
                .FirstOrDefaultAsync(x => x.Id == userPhotoId);

            return userPhoto;
            
                
               

        }

        public async  Task<GetUserPhotoInfoDto> GetUserPhotoInfoDtoByPhotoId(int userPhotoId)
        {
            var comments = await _getUserPhotoCommentsBusiness
                            .GetCommentDtosByUserPhotoId(userPhotoId);

            var likes = await _getLikesPhotoBusiness.GetLikesPhotoDtosByUserPhotoId(userPhotoId);
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
                LikesPhotoDtos = likes,
                Comments = comments
            };
                                    
                                        
                                    
                
                
                
        }
    }
}
