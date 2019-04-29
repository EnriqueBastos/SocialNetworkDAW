using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application
{
    public class CommentsByPhotoIdQuery
    {
        private readonly IGetCommentsBusiness _getComments;

        public CommentsByPhotoIdQuery(IGetCommentsBusiness getComments)
        {
            _getComments = getComments;
        }

        public IList<CommentDto> GetComments(int PhotoId)
        {
            return _getComments.GetComments(PhotoId);
        }
    }
}
