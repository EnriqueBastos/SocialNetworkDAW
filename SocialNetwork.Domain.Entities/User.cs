using System;
using System.Collections.Generic;

namespace SocialNetwork.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateBirthday { get; set; }

        public byte[] PhotoProfile { get; set; }

        public string BackgroundApp { get; set; }

        public bool Private { get; set; }

        public ICollection<Contact> Contacts { get; set; }

        public ICollection<UserPhotoComment> UserPhotoComments { get; set; }

        public ICollection<Music> Musics { get; set; }

        public ICollection<GroupChat> GroupChats { get; set; }
    }
}
