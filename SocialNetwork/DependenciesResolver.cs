
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Application;
using SocialNetwork.Application.MusicQuerys;
using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Business.MusicBusiness;
using SocialNetwork.Domain.Business.PhotoCommentBusiness;
using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Infraestructure.Repository;


namespace SocialNetwork
{
    public class DependenciesResolver
    {
        public static void RegisterOn(IServiceCollection services)
        {
            services.AddTransient<IUserPhotoQuery, PhotosQuery>();
            services.AddTransient<IGetLastUserPhotosBusiness, GetLastUserPhotosBusiness>();
            services.AddTransient<IUserPhotoRepository, UserPhotoRepository>();
            services.AddTransient<IGetUserPhotoBusiness,GetUserPhotoBusiness>();
            services.AddTransient<IDeleteUserPhotoBusiness, DeletePhotoBusiness>();

            services.AddTransient<IMusicQuery, MusicQuery>();
            services.AddTransient<IGetMusicBusiness, GetMusicBusiness>();
            services.AddTransient<IMusicRepository, MusicRepository>();

            services.AddTransient<IUserQuery, UserQuery>();
            services.AddTransient<IGetProfileBusiness, GetProfileBusiness>();
            services.AddTransient<IDeleteUserBusiness, DeleteUserBusiness>();
            services.AddTransient<IAddUserBusiness, AddUserBusiness>();
            services.AddTransient<IGetUserBusiness, GetUserBusiness>();
            services.AddTransient<IUserRepository, UserRepository>();

        }
    }
}
