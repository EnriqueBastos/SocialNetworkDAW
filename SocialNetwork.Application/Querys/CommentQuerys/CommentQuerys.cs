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

        private readonly IDeleteUserPhotoCommentBusiness _deleteCommentBusiness;

        public CommentQuerys(IAddUserPhotoCommentBusiness addCommentBusiness,
            IGetUserPhotoCommentsBusiness getCommentsBusiness,
            IDeleteUserPhotoCommentBusiness deleteCommentBusiness)
        {
            _addCommentBusiness = addCommentBusiness;

            _getCommentsBusiness = getCommentsBusiness;

            _deleteCommentBusiness = deleteCommentBusiness;

        }
        public void AddComment(CommentDto comment)
        {
            _addCommentBusiness.AddUserPhotoComment(comment);
        }

        public void DeleteCommenet(CommentDto comment)
        {
            _deleteCommentBusiness.DeleteUserPhotoCommentByCommentDto(comment);
        }

        public IList<CommentDto> GetCommentsByPhotoId(int idPhoto)
        {
            return _getCommentsBusiness.GetComments(idPhoto);
        }
    }
}
