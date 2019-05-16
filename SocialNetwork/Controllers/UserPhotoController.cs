﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserPhotoController : ControllerBase
    {
        IUserPhotoQuery _userPhotoQuery;

        public UserPhotoController(IUserPhotoQuery userPhotoQuery)
        {
            _userPhotoQuery = userPhotoQuery;
        }
        // GET: api/UserPhoto
        [HttpGet]
        [ActionName("getPhotos")]
        public IList<GetPhotoDto> Get()
        {
            return _userPhotoQuery.GetLastPhotos();
        }

        // GET: api/UserPhoto/5
        [HttpGet("{id}", Name = "GetUserPhotos")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserPhoto
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/UserPhoto/5
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
