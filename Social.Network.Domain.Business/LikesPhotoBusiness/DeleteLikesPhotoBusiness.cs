using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos.PhotoDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.LikesPhotoBusiness
{
    public class DeleteLikesPhotoBusiness : IDeleteLikesPhotoBusiness
    {
        private readonly ILikesPhotoRepository _likesPhotoRepository;
        private readonly IGetLikesPhotoBusiness _getLikesPhotoBusiness;
        public DeleteLikesPhotoBusiness(ILikesPhotoRepository likesPhotoRepository, IGetLikesPhotoBusiness getLikesPhotoBusiness)
        {
            _likesPhotoRepository = likesPhotoRepository;
            _getLikesPhotoBusiness = getLikesPhotoBusiness;
        }

        public async Task DeleteLikesPhotoByLikesPhotoDto(LikesPhotoDto likesPhotoDto)
        {
            var likesPhoto = await _getLikesPhotoBusiness.GetLikesPhotoByLikesPhotoDto(likesPhotoDto);

            _likesPhotoRepository.DeleteLikesPhoto(likesPhoto);
        }
    }
}
