
using System.Collections.Generic;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application;
using SocialNetwork.Application.Commands.ContactCommands;
using SocialNetwork.Application.Commands.ContactNotificationCommands;
using SocialNetwork.Application.Querys.ContactQuerys;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactQuery _contactQuery;
        private readonly IUserQuery _userQuery;
        private readonly IAddContactCommandHandler _addContactCommandHandler;
        private readonly IDeleteContactNotificationCommandHandler _deleteContactNotificationCommandHandler;
        private readonly IAddContactNotificationCommandHandler _addContactNotificationCommandHandler;
        private readonly IDeleteContactCommandHandler _deleteContactCommandHandler;
        public ContactsController(
            IContactQuery contactQuery,
            IUserQuery userQuery ,
            IAddContactCommandHandler addContactCommandHandler,
            IDeleteContactNotificationCommandHandler deleteContactNotificationCommandHandler,
            IAddContactNotificationCommandHandler addContactNotificationCommandHandler,
            IDeleteContactCommandHandler deleteContactCommandHandler
            )

        {
            _contactQuery = contactQuery;
            _userQuery = userQuery;
            _addContactCommandHandler = addContactCommandHandler;
            _deleteContactNotificationCommandHandler = deleteContactNotificationCommandHandler;
            _addContactNotificationCommandHandler = addContactNotificationCommandHandler;
            _deleteContactCommandHandler = deleteContactCommandHandler;
        }
        

        // GET: api/Contacts/getFriends/5
        [HttpGet("{id}", Name = "GetListFrieds")]
        [ActionName("getFriends")]
        public async Task<IList<ProfileDto>> GetContactsFriendsProfile(int id)
        {
            return await _contactQuery.GetListContactProfileByUserId(id);

        }
        // POST: api/Contacts/searchContacts
        
        [HttpPost]
        [ActionName("searchContacts")]
        public async Task<IList<ProfileDto>> GetContactsProfileByContactDto([FromBody]SearchContactDto searchContactDto)
        {
            return await _contactQuery.SearchContactBySearchContactDto(searchContactDto);

        }

        // POST: api/Contacts/AddContact
        [HttpPost]
        [ActionName("AddContact")]
        public async Task AddContact([FromBody] ContactDto contact)
        {
            await _addContactCommandHandler.Handler(contact);
        }


        // POST: api/Contacts/DeclineContact
        [HttpPost]
        [ActionName("DeclineContact")]
        public async Task DeclineContact([FromBody] ContactDto contact)
        {
            await _deleteContactNotificationCommandHandler.Handler(contact);
        }

        // POST: api/Contacts/sendFriendRequest
        [HttpPost]
        [ActionName("sendFriendRequest")]
        public async Task AddContactNotification([FromBody] ContactDto contact)
        {
            await _addContactNotificationCommandHandler.Handler(contact);
        }

        // POST: api/Contacts/deleteContact
        [HttpPost]
        [ActionName("deleteContact")]
        public async Task DeleteContact([FromBody] ContactDto contact)
        {
            await _deleteContactCommandHandler.Handler(contact);
        }
    }
}
