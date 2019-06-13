using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Querys.ContactQuerys
{
    public class ContactQuery : IContactQuery
    {
        private readonly IGetContactBusiness _getContactBusiness;

        public ContactQuery(IGetContactBusiness getContactBusiness)
        {
            _getContactBusiness = getContactBusiness;
        }

        public async Task<IList<ProfileDto>> GetListContactProfileByUserId(int userId)
        {
            return  await _getContactBusiness.GetAllProfileContactsByUserId(userId);
        }

        public async Task<IList<ProfileDto>> SearchContactBySearchContactDto(SearchContactDto searchContactDto)
        {
            return await _getContactBusiness.GetProfileDtosBySearchContactDto(searchContactDto);
        }

        



    }
}
