using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application
{
    public interface IUserPhotoQuery
    {
        IList<GetPhotoDto> GetLastPhotosContacts(int userId);


        Task<GetPhotoDto> GetPhotoByPhotoId(int PhotoId);

        Task<IList<GetPhotoDto>> GetLastPhotosUserByUserId(int userId);

        Task<GetUserPhotoInfoDto> GetUserPhotoInfoDtoByUserPhotoId(int userPhotoId);





    }
}
