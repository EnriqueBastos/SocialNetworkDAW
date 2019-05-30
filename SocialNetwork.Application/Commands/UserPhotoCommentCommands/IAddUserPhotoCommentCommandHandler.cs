using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserPhotoCommentCommands
{
    public interface IAddUserPhotoCommentCommandHandler
    {
        Task Handler(CommentDto commentDto);
    }
}