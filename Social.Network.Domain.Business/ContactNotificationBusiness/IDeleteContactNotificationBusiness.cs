using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactNotificationBusiness
{
    public interface IDeleteContactNotificationBusiness
    {
        Task DeleteContactNotification(int contactNotificationId);
    }
}