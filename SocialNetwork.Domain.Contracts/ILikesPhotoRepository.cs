using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface ILikesPhotoRepository : IRepository
    {
        IQueryable<LikesPhoto> GetLikesPhoto();

        void DeleteLikesPhoto(LikesPhoto likesPhoto);

        Task AddLikesPhoto(LikesPhoto likesPhoto);
    }
}
