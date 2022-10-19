using InitialTry.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTry.Application.Contracts.Persistence
{
    public interface ILoginRepository
    {
        bool LoginUser(string username, string password);
    }
}
