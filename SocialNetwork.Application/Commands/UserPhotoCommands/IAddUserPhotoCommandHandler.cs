using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserPhotoCommands
{
    public interface IAddUserPhotoCommandHandler
    {

        Task Handler(AddPhotoDto photo);
    }
}