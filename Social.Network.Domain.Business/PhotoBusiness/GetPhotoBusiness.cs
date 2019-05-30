using SocialNetwork.Domain.Contracts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public class GetPhotoBusiness :IGetPhotoBusiness
    {
        private readonly IPhotoRepository _photoRepository;

        public GetPhotoBusiness(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public int GetIdLastPhoto()
        {
            return _photoRepository
                .GetPhoto()
                .LastOrDefault()
                .Id;
        }
    }
}
