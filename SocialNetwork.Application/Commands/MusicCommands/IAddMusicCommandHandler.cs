using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.MusicCommands
{
    public interface IAddMusicCommandHandler
    {
        Task Handler(MusicDto music);
    }
}