
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UploadPhotoController : ControllerBase
    {
        // GET: api/UploadPhoto
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UploadPhoto/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UploadPhoto
        [HttpPost]
        public async Task<IActionResult> Post(IFormFile photo)
        {
            long size = photo.Length;

            // full path to file in temp location
            var filePath = Path.GetTempFileName();
            
                if (size > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await photo.CopyToAsync(stream);
                    }
                }
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = 1, size, filePath });
        }

        // PUT: api/UploadPhoto/5
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
