using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application.Querys.ContactQuerys
{
    public class ContactQuery : IContactQuery
    {
        private readonly IGetContactBusiness _getContactBusiness;

        public ContactQuery(IGetContactBusiness getContactBusiness)
        {
            _getContactBusiness = getContactBusiness;
        }

        public IList<ProfileDto> GetListContactProfileByUserId(int userId)
        {
            return _getContactBusiness.GetAllProfileContactsByUserId(userId);
        } 
    }
}
