using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.PhotoCommands
{
    public interface IAddPhotoCommandHandler
    {
        Task Handler(PhotoDetailsDto photo);
    }
}