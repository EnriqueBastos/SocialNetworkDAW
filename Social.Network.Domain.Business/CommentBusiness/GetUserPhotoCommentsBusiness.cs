using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business
{
    public class GetUserPhotoCommentsBusiness : IGetUserPhotoCommentsBusiness
    {
        private readonly IUserPhotoCommentRepository _commentRepository;

        public GetUserPhotoCommentsBusiness(IUserPhotoCommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IList<CommentDto> GetComments(int idPhoto)
        {
            return _commentRepository
                .GetUserPhotoComment()
                .Select(comment =>
                new CommentDto
                {

                    UserName = comment.User.Name,
                    CommentText = comment.CommentText,
                    PhotoId = comment.UserPhotoId

                }).Where(comment => comment.PhotoId == idPhoto)
                .ToList();
        }
    }
}
