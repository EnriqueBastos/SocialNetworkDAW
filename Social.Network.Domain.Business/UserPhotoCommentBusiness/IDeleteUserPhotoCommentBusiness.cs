using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.CommentBusiness
{
    public interface IDeleteUserPhotoCommentBusiness
    {
        Task DeleteUserPhotoCommentsByPhotoId(int photoId);
    }
}
