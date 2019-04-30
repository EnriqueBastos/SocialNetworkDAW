using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IDeleteUserBusiness
    {
        void DeleteUserByUserId(int userId);
    }
}
