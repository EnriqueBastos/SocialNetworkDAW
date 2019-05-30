using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business
{
    public interface IGetUserPhotoCommentsBusiness
    {
        Task<IList<CommentDto>> GetCommentsByUserPhotoId(int idUserPhoto);
    }
}
