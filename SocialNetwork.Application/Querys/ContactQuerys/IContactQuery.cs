using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;


namespace SocialNetwork.Application.Querys.ContactQuerys
{
    public interface IContactQuery
    {
        IList<ProfileDto> GetListContactProfileByUserId(int userId);
    }
}
