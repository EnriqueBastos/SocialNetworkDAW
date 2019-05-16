
using System.Collections.Generic;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Querys.ContactQuerys;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetContactsController : ControllerBase
    {
        IContactQuery _contactQuery;
        public GetContactsController(IContactQuery contactQuery)
        {
            _contactQuery = contactQuery;
        }
        // GET: api/GetContacts
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GetContacts/5
        [HttpGet("{id}", Name = "GetListContact")]
        public async Task<IList<ProfileDto>> Get(int id)
        {
            return await _contactQuery.GetListContactProfileByUserId(id);

        }

        // POST: api/GetContacts
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GetContacts/5
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
