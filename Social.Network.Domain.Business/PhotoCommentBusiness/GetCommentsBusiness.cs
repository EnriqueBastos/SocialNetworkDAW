using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business
{
    public class GetCommentsBusiness
    {
        private readonly ICommentRepository _commentRepository;

        public GetCommentsBusiness(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IList<CommentDto> GetComments(int idPhoto)
        {
            return _commentRepository
                .GetComments()
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
