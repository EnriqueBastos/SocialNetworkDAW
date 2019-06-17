using SocialNetwork.Domain.Dtos.PhotoDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.LikesPhotoCommands
{
    public interface IAddLikesPhotoCommandHandler
    {
        Task Handler(LikesPhotoDto likesPhotoDto);
    }
}