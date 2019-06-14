using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserPhotoCommands
{
    public interface IDeleteUserPhotoCommandHandler
    {
        Task DeleteUserPhotoByPhotoId(int photoId);
    }
}