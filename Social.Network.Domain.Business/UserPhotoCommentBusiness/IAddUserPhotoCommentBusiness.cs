using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.CommentBusiness
{
    public interface IAddUserPhotoCommentBusiness
    {
        Task AddUserPhotoComment(CommentDto comment);



    }
}
