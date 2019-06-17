using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Commands.LikesPhotoCommands;
using SocialNetwork.Domain.Dtos.PhotoDtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LikesPhotoController : ControllerBase
    {
        private readonly IDeleteLikesPhotoCommandHandler _deleteLikesPhotoCommandHandler;
        private readonly IAddLikesPhotoCommandHandler _addLikesPhotoCommandHandler;
        public LikesPhotoController(IDeleteLikesPhotoCommandHandler deleteLikesPhotoCommandHandler, IAddLikesPhotoCommandHandler addLikesPhotoCommandHandler)
        {
            _deleteLikesPhotoCommandHandler = deleteLikesPhotoCommandHandler;
            _addLikesPhotoCommandHandler = addLikesPhotoCommandHandler;
        }
        
        // POST: api/LikePhotos
        [HttpPost]
        [ActionName("AddLike")]
        public async Task AddLikesPhoto([FromBody] LikesPhotoDto likesPhotoDto)
        {
            await _addLikesPhotoCommandHandler.Handler(likesPhotoDto);
        }

        [HttpPost]
        [ActionName("DeleteLike")]
        public async Task DeleteLikesPhoto([FromBody] LikesPhotoDto likesPhotoDto)
        {
            await _deleteLikesPhotoCommandHandler.Handler(likesPhotoDto);
        }

    }
}
