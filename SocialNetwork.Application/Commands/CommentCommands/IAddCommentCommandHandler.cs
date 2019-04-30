using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.CommentCommands
{
    public interface IAddCommentCommandHandler
    {
        Task Handler(CommentDto comment);
    }
}