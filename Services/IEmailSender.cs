using System.Threading.Tasks;
using WebItProject.Models;

namespace WebItProject.Services
{
    public interface IEmailSender
    {
         Task SendAsync(EmailMessage message);
    }
}