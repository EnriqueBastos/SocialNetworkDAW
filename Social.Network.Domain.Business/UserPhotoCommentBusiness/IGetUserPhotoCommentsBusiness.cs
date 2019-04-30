using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;


namespace SocialNetwork.Domain.Business
{
    public interface IGetUserPhotoCommentsBusiness
    {
        IList<CommentDto> GetComments(int idPhoto);
    }
}
