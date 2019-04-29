using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;


namespace SocialNetwork.Application
{
    interface ICommentsByPhotoIdQuery
    {
        IList<CommentDto> GetComments(int PhotoId);
    }
}
