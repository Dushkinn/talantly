using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using talantly.Interface;
using talantly.Models.User;
using talanty.Data;

namespace talantly.Repository
{
    public class AccountRoleRepository : BaseRepository<AccountRole>, IAccountRoleRepository
    {
        public AccountRoleRepository(ApplicationContext context) : base(context)
        {
        }

    }

}
