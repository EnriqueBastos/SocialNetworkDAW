using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace SocialNetwork.Domain.Entities
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }


        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateBirthday { get; set; }

        public byte[] PhotoProfile { get; set; }

        public string BackgroundApp { get; set; }

        public ICollection<GroupChat> GroupChat { get; set; }

        public ICollection<Music> Music { get; set; }

        public ICollection<Contact> Contacts { get; set; }
        [NotMapped]
        public ICollection<UserPhotoComment> UserPhotoComments { get; set; }
    }
}
