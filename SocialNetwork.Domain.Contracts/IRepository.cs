using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Contracts
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get;}
    }
}
