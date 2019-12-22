using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using talantly.Helper;
using talantly.Interface;
using talantly.Models.User;
using talantly.Repository;
using talanty.Data;

namespace talantly.Services
{
    public class AccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public Answer Login(Account account) {
            Boolean answer = _accountRepository
                .Any(i => i.login == account.login && i.password == account.password);
            return new Answer(answer);
        }
        public Account Register(Account account) 
        {
            account.id = Guid.NewGuid();
            _accountRepository.Save(account);
            return account;
        }

        public Account UpdateUserProfile(Account account)
        {
            _accountRepository.Update(account);
            return account;
        }
    }
}
