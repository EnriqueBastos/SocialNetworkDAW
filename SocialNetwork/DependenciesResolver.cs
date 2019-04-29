using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Application;
using SocialNetwork.Application.MusicQuerys;
using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Business.MusicBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Infraestructure.Repository;
using System;

namespace SocialNetwork
{
    public class DependenciesResolver
    {
        public static void registerOn(IServiceCollection services)
        {
            services.AddTransient<IPhotoQuerys, LastPhotosQuery>();
            services.AddTransient<IGetLastPhotosBusiness, GetLastPhotosBusiness>();
            services.AddTransient<IUserPhotoRepository, UserPhotoRepository>();
            

            services.AddTransient<IMusicQuerys, MusicQuery>();
            services.AddTransient<IGetMusicBusiness, GetMusicBusiness>();
            services.AddTransient<IMusicRepository, MusicRepository>();



        }
    }
}
