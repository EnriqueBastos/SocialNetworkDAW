using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IUnitOfWork
    {
        Task Save();
    }
}
