using SocialNetwork.Domain.Dtos.PhotoDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.LikesPhotoCommands
{
    public interface IDeleteLikesPhotoCommandHandler
    {
        Task Handler(LikesPhotoDto likesPhotoDto);
    }
}