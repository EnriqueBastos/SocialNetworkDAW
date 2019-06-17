using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos.PhotoDtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.LikesPhotoBusiness
{
    public class GetLikesPhotoBusiness : IGetLikesPhotoBusiness
    {
        private readonly ILikesPhotoRepository _likesPhotoRepository;

        public GetLikesPhotoBusiness(ILikesPhotoRepository likesPhotoRepository)
        {
            _likesPhotoRepository = likesPhotoRepository;
        }

        public async Task<IList<LikesPhotoDto>> GetLikesPhotoDtosByUserPhotoId(int userPhotoId)
        {
            return await _likesPhotoRepository
                .GetLikesPhoto()
                .Include( x => x.User)
                .Where(x => x.UserPhotoId == userPhotoId)
                .Select(x => new LikesPhotoDto
                {
                    UserId = x.UserId,
                    UserPhotoId = x.UserPhotoId,
                    UserName = x.User.Name,
                    PhotoProfile = x.User.PhotoProfile
                })
                .ToListAsync();
        }

        public async Task<LikesPhoto> GetLikesPhotoByLikesPhotoDto(LikesPhotoDto likesPhotoDto)
        {
            return await _likesPhotoRepository
                .GetLikesPhoto()
                .FirstOrDefaultAsync(
                x => 
                x.UserId == likesPhotoDto.UserId &&
                x.UserPhotoId == likesPhotoDto.UserPhotoId
                );
        }
    }
}
