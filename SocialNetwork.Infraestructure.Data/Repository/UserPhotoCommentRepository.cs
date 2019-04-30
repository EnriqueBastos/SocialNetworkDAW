using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Infraestructure.Repository
{
    public class UserPhotoCommentRepository : IUserPhotoCommentRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public UserPhotoCommentRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        

        public IQueryable<UserPhotoComment> GetUserPhotoComment()
        {
            return _socialNetworkContext.Set<UserPhotoComment>();
        }

        public void AddUserPhotoComment(UserPhotoComment comment)
        {
            _socialNetworkContext.Set<UserPhotoComment>().Add(comment);
            
        }

        public void DeleteUserPhotoComment(UserPhotoComment comment)
        {
            _socialNetworkContext.Set<UserPhotoComment>().Remove(comment);

            
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _socialNetworkContext;
            }
        }
    }
}
