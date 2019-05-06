
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Application;
using SocialNetwork.Application.Commands.ContactCommands;
using SocialNetwork.Application.Commands.MusicCommands;
using SocialNetwork.Application.MusicQuerys;
using SocialNetwork.Application.Querys.ContactQuerys;
using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Business.ContactBusiness;
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
            services.AddTransient<IGetListUserPhotosBusiness, GetListUserPhotosBusiness>();
            services.AddTransient<IUserPhotoRepository, UserPhotoRepository>();
            services.AddTransient<IGetUserPhotoBusiness,GetUserPhotoBusiness>();
            services.AddTransient<IDeleteUserPhotoBusiness, DeletePhotoBusiness>();

            services.AddTransient<IMusicQuery, MusicQuery>();
            services.AddTransient<IAddMusicCommandHandler, AddMusicCommandHandler>();
            services.AddTransient<IGetMusicBusiness, GetMusicBusiness>();
            services.AddTransient<IAddMusicBusiness, AddMusicBusiness>();
            services.AddTransient<IMusicRepository, MusicRepository>();

            services.AddTransient<IUserQuery, UserQuery>();
           
            services.AddTransient<IDeleteUserBusiness, DeleteUserBusiness>();
            services.AddTransient<IAddUserBusiness, AddUserBusiness>();
            services.AddTransient<IGetUserBusiness, GetUserBusiness>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IContactQuery, ContactQuery>();
            services.AddTransient<IAddContactCommandHandler, AddContactCommandHandler>();
            services.AddTransient<IDeleteContactBusiness, DeleteContactBusiness>();
            services.AddTransient<IDeleteContactCommandHandler, DeleteContactCommandHandler>();
            services.AddTransient<IAddContactBusiness, AddContactBusiness>();
            services.AddTransient<IGetContactBusiness, GetContactBusiness>();
            services.AddTransient<IContactRepository, ContactRepository>();
            
        }
    }
}
