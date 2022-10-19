using InitialTry.Application.Contracts.Persistence;
using InitialTry.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTry.Persistence.Repositories
{
    public class LoginRepository:BaseRepository<Login>,ILoginRepository
    {
        private readonly ILogger _logger;
        //private readonly ApplicationDbContext _dbContext;
        public LoginRepository(ApplicationDbContext dbContext,ILogger<Login> logger) : base(dbContext, logger)
        {
            //_dbContext = dbContext;
            _logger = logger;
        }

        public bool LoginUser(string username, string password)
        {
            _logger.LogInformation("Login initiated");
            bool user = LoginUserRepo(username, password);
            if (user == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
