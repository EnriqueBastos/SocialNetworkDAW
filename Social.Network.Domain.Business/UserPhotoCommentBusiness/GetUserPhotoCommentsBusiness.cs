using SocialNetwork.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business
{
    public class GetUserPhotoCommentsBusiness : IGetUserPhotoCommentsBusiness
    {
        private readonly IUserPhotoCommentRepository _commentRepository;

        public GetUserPhotoCommentsBusiness(IUserPhotoCommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<IList<CommentDto>> GetCommentDtosByUserPhotoId(int idUserPhoto)
        {
            
            return await _commentRepository
                .GetUserPhotoComment()
                .OrderByDescending(comment => comment.Id)
                .Select(comment =>
                new CommentDto
                {
                    Id = comment.Id,
                    UserId = comment.UserId,
                    UserName = comment.User.Name,
                    CommentText = comment.CommentText,
                    UserPhotoId = comment.UserPhotoId

                })
                .Where(comment => comment.UserPhotoId == idUserPhoto)
                .ToListAsync();
        }

        public async Task<IList<UserPhotoComment>> GetUserPhotoCommentsByUserPhotoId(int userPhotoId)
        {
            return await _commentRepository
                .GetUserPhotoComment()
                .Where(comment => comment.UserPhotoId == userPhotoId)
                .ToListAsync();
        }

        
    }
}
