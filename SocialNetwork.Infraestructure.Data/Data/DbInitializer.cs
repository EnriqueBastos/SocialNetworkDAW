
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;


namespace SocialNetwork.Data
{
    public class DbInitializer
    {
        public static void Initialize(SocialNetworkContext Context)
        {
            Context.Database.EnsureCreated();

            if (Context.Users.Any())
            {
                return;
            }

            var Users = new User[]
            {
                new User{Name = "Enrique",LastName="Bastos",Email ="quiquebastos@hotmail.com" , Password="123",DateBirthday=DateTime.Parse("1998-04-28") },

                new User{Name = "Alejandro",LastName="Muñoz", Password="12345",DateBirthday=DateTime.Parse("1998-10-23") },

                new User{Name = "Daniel",LastName="Esteban", Password="12345",DateBirthday=DateTime.Parse("1997-01-04") },

                new User{Name = "Pepe",LastName="Vaquero", Password="12345",DateBirthday=DateTime.Parse("2000-12-10") }
            };

            foreach (User User in Users)
            {
                Context.Users.Add(User);
            }

            Context.SaveChanges();

            var Photos = new Photo[]
            {
                new Photo {Id=1, Title="En la sierra", Likes=0 },

                new Photo {Id=2, Title="En la playa",Likes=0 },

                new Photo {Id=3,  Title="En la sierra", Likes=0 },

                new Photo {Id=4, Title="En la sierra", Likes=0 },
            };

            foreach (Photo photo in Photos)
            {
                Context.Photos.Add(photo);
            }

            Context.SaveChanges();

            var Musics = new Music[]
            {
                new Music{ Id = 0, UserId=1, UrlMusic="" },

                new Music{ Id = 0, UserId=3, UrlMusic="" },

                new Music{ Id = 0, UserId=4, UrlMusic="" },

                new Music{ Id = 0, UserId=2, UrlMusic="" }
            };

            foreach (Music song in Musics)
            {
                Context.Musics.Add(song);
            }

            Context.SaveChanges();



        }
    
    }
}
