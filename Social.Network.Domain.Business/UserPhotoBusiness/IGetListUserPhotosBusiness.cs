using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public interface IGetListUserPhotosBusiness
    {
        IList<GetPhotoDto> GetLastPhotosContacts(int userId);

        Task<IList<GetPhotoDto>> GetListPhotosByUserId(int userId);
    }
}
