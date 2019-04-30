using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;

namespace SocialNetwork.Application.CommentQuerys
{
    public interface ICommentQuerys
    {
        void AddComment(CommentDto comment);
        void DeleteCommenet(CommentDto comment);

        IList<CommentDto> GetCommentsByPhotoId(int idPhoto);
    }
}
