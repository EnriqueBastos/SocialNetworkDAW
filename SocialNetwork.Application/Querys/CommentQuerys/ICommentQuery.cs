using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;

namespace SocialNetwork.Application.CommentQuerys
{
    public interface ICommentQuery
    {
        
        

        IList<CommentDto> GetCommentsByPhotoId(int idPhoto);
    }
}
