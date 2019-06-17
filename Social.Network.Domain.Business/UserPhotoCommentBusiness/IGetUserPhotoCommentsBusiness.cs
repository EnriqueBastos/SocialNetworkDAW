using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business
{
    public interface IGetUserPhotoCommentsBusiness
    {
        Task<IList<CommentDto>> GetCommentDtosByUserPhotoId(int idUserPhoto);

        Task<IList<UserPhotoComment>> GetUserPhotoCommentsByUserPhotoId(int userPhotoId);
    }
}
