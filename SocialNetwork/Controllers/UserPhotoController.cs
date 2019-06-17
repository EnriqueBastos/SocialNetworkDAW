using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application;
using SocialNetwork.Application.Commands.UserPhotoCommands;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.PhotoDtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserPhotoController : ControllerBase
    {
        IUserPhotoQuery _userPhotoQuery;
        IAddUserPhotoCommandHandler _addUserPhotoCommandHandler;
        IDeleteUserPhotoCommandHandler _deleteUserPhotoCommandHandler;

        public UserPhotoController(
            IUserPhotoQuery userPhotoQuery,
            IAddUserPhotoCommandHandler addUserPhotoCommandHandler,
            IDeleteUserPhotoCommandHandler deleteUserPhotoCommandHandler
            )
        {
            _userPhotoQuery = userPhotoQuery;
            _addUserPhotoCommandHandler = addUserPhotoCommandHandler;
            _deleteUserPhotoCommandHandler = deleteUserPhotoCommandHandler;
        }
        
        [HttpGet("{userId}", Name = "GetUserPhotosContacts")]
        [ActionName("getPhotoContacts")]

        public IList<GetPhotoDto> GetPhotoContactsByUserId(int userId)
        {
            return _userPhotoQuery.GetLastPhotosContacts(userId);
        }

        [HttpGet("{userPhotoId}", Name = "GetPhotoInfo")]
        [ActionName("getPhotoInfo")]

        public async Task<GetUserPhotoInfoDto> GetPhotoInfo(int userPhotoId)
        {
            return await _userPhotoQuery.GetUserPhotoInfoDtoByUserPhotoId(userPhotoId);
        }


        // GET: api/UserPhoto/5
        [HttpGet("{userId}", Name = "GetUserPhotosUser")]
        [ActionName("getPhotosProfile")]

        public async Task<IList<GetPhotoDto>> GetPhotosByUserId(int userId)
        {
            return await _userPhotoQuery.GetLastPhotosUserByUserId(userId);
        }

        // POST: api/UserPhoto
        [HttpPost]
        [ActionName("AddPhoto")]
        public async Task AddPhoto([FromBody] AddPhotoDto photo)
        {
             await _addUserPhotoCommandHandler.Handler(photo);
        }

        [HttpPost]
        [ActionName("DeletePhoto")]
        public async Task DeletePhoto(DeletePhotoDto photo)
        {
            await _deleteUserPhotoCommandHandler.DeleteUserPhotoByPhotoId(photo.PhotoId);
        }

        
    }
}
