using SocialNetwork.Domain.Business.ContactNotificationBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ContactNotificationCommands
{
    public class DeleteContactNotificationCommandHandler : IDeleteContactNotificationCommandHandler
    {
        private readonly IDeleteContactNotificationBusiness _deleteContactNotificationBusiness;

        private readonly IContactNotificationRepository _repository;

        public DeleteContactNotificationCommandHandler(IDeleteContactNotificationBusiness deleteContactNotificationBusiness , IContactNotificationRepository repository)
        {
            _deleteContactNotificationBusiness = deleteContactNotificationBusiness;

            _repository = repository;
            
        }

        public async Task Handler(ContactDto contactDto)
        {
            
            await _deleteContactNotificationBusiness.DeleteContactNotification(contactDto.ContactNotificationId);

            await _repository.UnitOfWork.Save();
        }
    }
}
