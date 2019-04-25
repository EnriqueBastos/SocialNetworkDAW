
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.Data;
using System.Threading.Tasks;

namespace SocialNetwork.Infraestructure.Repository
{
    class UserRepository
    {
        private readonly SocialNetworkContext _context;

        public async Task<IList<byte>> GetImagesByUserIdAsync(int userId)

        {

            var images =(IList<byte>)(from userPhoto in _context.UserPhotos
                          where userPhoto.Id == userId
                          select userPhoto.Photo.BytesPhoto);

            return images;

            
             

        }
    }
}
