using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public class GetPhotoBusiness : IGetPhotoBusiness
    {
        private readonly IPhotoRepository _photoRepository;

        public GetPhotoBusiness(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public async Task<Photo> GetLastPhoto()
        {
            return await _photoRepository
                .GetPhoto()
                .LastOrDefaultAsync();
        }
    }
}
