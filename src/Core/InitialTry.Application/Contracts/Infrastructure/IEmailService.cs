using InitialTry.Application.Models.Mail;
using System.Threading.Tasks;

namespace InitialTry.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
