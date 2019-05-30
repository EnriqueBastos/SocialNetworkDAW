using SocialNetwork.Domain.Business.CommentBusiness;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserPhotoCommentCommands
{
    public class AddUserPhotoCommentCommandHandler : IAddUserPhotoCommentCommandHandler
    {
        private readonly IAddUserPhotoCommentBusiness _addUserPhotoCommentBusiness;

        public AddUserPhotoCommentCommandHandler(IAddUserPhotoCommentBusiness addUserPhotoCommentBusiness)
        {
            _addUserPhotoCommentBusiness = addUserPhotoCommentBusiness;
        }

        public async Task Handler(CommentDto commentDto)
        {
            await _addUserPhotoCommentBusiness
                .AddUserPhotoComment(commentDto);
        }
    }
}
