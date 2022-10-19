using InitialTry.Domain.Entities;
using System.Threading.Tasks;

namespace InitialTry.Application.Contracts.Persistence
{
    public interface IMessageRepository : IAsyncRepository<Message>
    {
        public Task<Message> GetMessage(string Code, string Lang);
    }
}
