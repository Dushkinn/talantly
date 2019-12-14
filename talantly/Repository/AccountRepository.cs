using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using talantly.Interface;
using talantly.Models.User;
using talanty.Data;

namespace talantly.Repository
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
