using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.CommentCommands
{
    public interface IDeleteCommentCommandHandler
    {
        Task Handler(CommentDto comment);
    }
}