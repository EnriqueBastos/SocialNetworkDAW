using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Business.CommentBusiness;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Application.CommentQuerys
{
    public class CommentQuerys : ICommentQuerys
    {
        private readonly IAddUserPhotoCommentBusiness _addCommentBusiness;

        private readonly IGetUserPhotoCommentsBusiness _getCommentsBusiness;

        

        public CommentQuerys(IAddUserPhotoCommentBusiness addCommentBusiness,
            IGetUserPhotoCommentsBusiness getCommentsBusiness)
        {
            _addCommentBusiness = addCommentBusiness;

            _getCommentsBusiness = getCommentsBusiness;

            

        }
      

        public IList<CommentDto> GetCommentsByPhotoId(int idPhoto)
        {
            return _getCommentsBusiness.GetComments(idPhoto);
        }
    }
}
