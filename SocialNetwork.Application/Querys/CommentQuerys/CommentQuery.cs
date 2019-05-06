using System.Collections.Generic;
using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Business.CommentBusiness;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Application.CommentQuerys
{
    public class CommentQuery : ICommentQuery
    {
        private readonly IAddUserPhotoCommentBusiness _addCommentBusiness;

        private readonly IGetUserPhotoCommentsBusiness _getCommentsBusiness;

        

        public CommentQuery(IAddUserPhotoCommentBusiness addCommentBusiness,
            IGetUserPhotoCommentsBusiness getCommentsBusiness)
        {
            _addCommentBusiness = addCommentBusiness;

            _getCommentsBusiness = getCommentsBusiness;

        }
      

        public IList<CommentDto> GetCommentsByPhotoId(int idPhoto)
        {
            return _getCommentsBusiness.GetCommentsByPhotoId(idPhoto);
        }
    }
}
