using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Commands.ContactCommands;
using SocialNetwork.Application.Querys.ContactQuerys;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactQuery _contactQuery;

        private readonly IAddContactCommandHandler _addContactCommandHandler;

        private readonly IDeleteContactCommandHandler _deleteContactCommandHandler;

        public ContactsController(IContactQuery contactQuery, IAddContactCommandHandler addContactCommandHandler, IDeleteContactCommandHandler deleteContactCommandHandler)
        {
            _contactQuery = contactQuery;
            _addContactCommandHandler = addContactCommandHandler;
            _deleteContactCommandHandler = deleteContactCommandHandler;
        }
        // GET: api/Contacts
        [HttpGet]
        public IList<ProfileDto> Get()
        {



            return _contactQuery.GetListContactProfileByUserId(2);
        }

        // GET: api/Contacts/5
        [HttpGet("{id}", Name = "GetContacts")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contacts
        [HttpPost]
        public async Task Post(ContactDto contact)
        {
            await _deleteContactCommandHandler.Handler(contact);
        }

        // PUT: api/Contacts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
