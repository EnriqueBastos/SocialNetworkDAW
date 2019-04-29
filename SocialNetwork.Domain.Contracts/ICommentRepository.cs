using System;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.Domain.Entities;


namespace SocialNetwork.Domain.Contracts
{
    public interface ICommentRepository
    {
        IQueryable<UserPhotoComment> GetComments();
    }
}
