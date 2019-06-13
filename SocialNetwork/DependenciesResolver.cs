
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Application;
using SocialNetwork.Application.Commands;
using SocialNetwork.Application.Commands.ContactCommands;
using SocialNetwork.Application.Commands.ContactNotificationCommands;
using SocialNetwork.Application.Commands.MessageChatCommands;
using SocialNetwork.Application.Commands.MusicCommands;
using SocialNetwork.Application.Commands.PhotoCommands;
using SocialNetwork.Application.Commands.UserCommands;
using SocialNetwork.Application.Commands.UserPhotoCommands;
using SocialNetwork.Application.Commands.UserPhotoCommentCommands;
using SocialNetwork.Application.MusicQuerys;
using SocialNetwork.Application.Querys.ChatQuerys;
using SocialNetwork.Application.Querys.ContactQuerys;
using SocialNetwork.Application.Querys.MessageChatQuerys;
using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Business.ChatBusiness;
using SocialNetwork.Domain.Business.CommentBusiness;
using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Business.ContactNotificationBusiness;
using SocialNetwork.Domain.Business.MessageChatBusiness;
using SocialNetwork.Domain.Business.MessageChatRepository;
using SocialNetwork.Domain.Business.MusicBusiness;
using SocialNetwork.Domain.Business.PhotoBusiness;
using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Business.UserPhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Infraestructure.Repository;


namespace SocialNetwork
{
    public class DependenciesResolver
    {
        public static void RegisterOn(IServiceCollection services)
        {
            //Photo dependencies
            services.AddTransient<IAddPhotoCommandHandler, AddPhotoCommandHandler>();
            services.AddTransient<IAddPhotoBusiness, AddPhotoBusiness> ();
            services.AddTransient<IPhotoRepository, PhotoRepository>();
            services.AddTransient<IGetPhotoBusiness, GetPhotoBusiness>();


            //UserPhoto dependencies
            services.AddTransient<IUserPhotoQuery, UserPhotosQuery>();
            services.AddTransient<IGetListUserPhotosBusiness, GetListUserPhotosBusiness>();
            services.AddTransient<IUserPhotoRepository, UserPhotoRepository>();
            services.AddTransient<IGetUserPhotoBusiness,GetUserPhotoBusiness>();
            services.AddTransient<IAddUserPhotoBusiness, AddUserPhotoBusiness>();
            services.AddTransient<IAddUserPhotoCommandHandler, AddUserPhotoCommandHandler>();
            
            //Music dependencies
            services.AddTransient<IMusicQuery, MusicQuery>();
            services.AddTransient<IAddMusicCommandHandler, AddMusicCommandHandler>();
            services.AddTransient<IDeleteMusicCommandHandler, DeleteMusicCommandHandler>();
            services.AddTransient<IDeleteMusicBusiness, DeleteMusicBusiness>();
            services.AddTransient<IGetMusicBusiness, GetMusicBusiness>();
            services.AddTransient<IAddMusicBusiness, AddMusicBusiness>();
            services.AddTransient<IMusicRepository, MusicRepository>();

            //User dependencies
            services.AddTransient<IUserQuery, UserQuery>();
            services.AddTransient<IAddUserCommandHandler, AddUserCommandHandler>();
            services.AddTransient<IDeleteUserBusiness, DeleteUserBusiness>();
            services.AddTransient<IAddUserBusiness, AddUserBusiness>();
            services.AddTransient<IGetUserBusiness, GetUserBusiness>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IEditUserCommandHandler, EditUserCommandHandler>();
            services.AddTransient<IEditUserBusiness, EditUserBusiness>();

            //Contact dependencies
            services.AddTransient<IContactQuery, ContactQuery>();
            services.AddTransient<IAddContactCommandHandler, AddContactCommandHandler>();
            services.AddTransient<IDeleteContactBusiness, DeleteContactBusiness>();
            services.AddTransient<IDeleteContactCommandHandler, DeleteContactCommandHandler>();
            services.AddTransient<IAddContactBusiness, AddContactBusiness>();
            services.AddTransient<IGetContactBusiness, GetContactBusiness>();
            services.AddTransient<IContactRepository, ContactRepository>();

            //UserPhotoComment dependencies
            services.AddTransient<IUserPhotoCommentRepository, UserPhotoCommentRepository>();
            services.AddTransient<IGetUserPhotoCommentsBusiness, GetUserPhotoCommentsBusiness>();
            services.AddTransient<IAddUserPhotoCommentBusiness, AddUserPhotoCommentBusiness>();
            services.AddTransient<IAddUserPhotoCommentCommandHandler, AddUserPhotoCommentCommandHandler>();

            //ContactNotifications dependencies
            services.AddTransient<IContactNotificationRepository, ContactNotificationRepository>();
            services.AddTransient<IGetContactNotificationBusiness, GetContactNotificationBusiness>();
            services.AddTransient<IAddContactNotificationBusiness, AddContactNotificationBusiness>();
            services.AddTransient<IDeleteContactNotificationBusiness, DeleteContactNotificationBusiness>();
            services.AddTransient<IDeleteContactNotificationCommandHandler, DeleteContactNotificationCommandHandler>();
            services.AddTransient<IAddContactNotificationCommandHandler, AddContactNotificationCommandHandler>();

            //MessageChat dependencies
            services.AddTransient<IMessageChatRepository, MessageChatRepository>();
            services.AddTransient<IAddMessageChatBusiness, AddMessageChatBusiness>();
            services.AddTransient<IReadMessagesChatCommandHandler, ReadMessagesChatCommandHandler>();
            services.AddTransient<IEditMessageChatBusiness, EditMessageChatBusiness>();
            services.AddTransient<IGetMessageChatBusiness, GetMessageChatBusiness>();
            services.AddTransient<IAddMessageChatCommandHandler, AddMessageChatCommandHandler>();
            services.AddTransient<IMessageChatQuery, MessageChatQuery>();

            //Chat dependencies
            services.AddTransient<IChatRepository, ChatRepository>();
            services.AddTransient<IGetChatBusiness , GetChatBusiness> ();
            services.AddTransient<IAddChatBusiness, AddChatBusiness>();
            services.AddTransient<IChatQuery, ChatQuery>();
            
        }
    }
}
