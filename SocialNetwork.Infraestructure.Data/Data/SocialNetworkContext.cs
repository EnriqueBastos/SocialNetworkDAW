
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Entities;


namespace SocialNetwork.Data
{
    public class SocialNetworkContext : DbContext
    {

        public SocialNetworkContext(DbContextOptions<SocialNetworkContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<Music> Musics { get; set; }

       
        public DbSet<UserPhotoComment> UserPhotoComments { get; set; }

        public DbSet<UserPhoto> UserPhotos { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<GroupChat> GroupChats { get; set; }

        public DbSet<MessageChat> MessageChats { get; set; }




    }
}
