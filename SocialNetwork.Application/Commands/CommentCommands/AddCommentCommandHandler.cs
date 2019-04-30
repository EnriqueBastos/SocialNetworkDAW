using SocialNetwork.Domain.Business.CommentBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.CommentCommands
{
    public class AddCommentCommandHandler : IAddCommentCommandHandler
    {
        private readonly IAddUserPhotoCommentBusiness _addUserPhotoCommentBusiness;
        private readonly IUserPhotoCommentRepository _userPhotoCommentRepository;

        public AddCommentCommandHandler(IAddUserPhotoCommentBusiness addUserPhotoCommentBusiness, IUserPhotoCommentRepository userPhotoCommentRepository)
        {
            _addUserPhotoCommentBusiness = addUserPhotoCommentBusiness;
            _userPhotoCommentRepository = userPhotoCommentRepository;
        }
        public async Task Handler(CommentDto comment)
        {
            _addUserPhotoCommentBusiness.AddUserPhotoComment(comment);
            await _userPhotoCommentRepository.UnitOfWork.Save();
        }
    }
}
