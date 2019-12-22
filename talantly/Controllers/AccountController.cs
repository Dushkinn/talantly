using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using talantly.Helper;
using talantly.Models.User;
using talantly.Services;

namespace talantly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly AccountService _accountService;
        public AccountController(AccountService accountService) 
        {
            _accountService = accountService;
        }
        // GET: api/Account
        //[HttpGet]
        //public Boolean Get()
        //{
        //    return false;
        //}

        // GET: api/Account/5
        [HttpPost]
        public IActionResult Post( Account account)
        {
            return Ok(new Account
            {
                login = "Damir",
                password = "12345"
             });
        }

        // POST: api/Account
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Account/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        // PUT: api/Account/5
        [HttpGet("{id}")]
        public void Get(int id)
        {
            
        }
        // DELETE: api/Account/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        // POST: api/Account/login
        [HttpPost("login")]
        public  IActionResult LogIn([FromForm]Account account)
        {
            return Ok(_accountService.Login(account));
        }
        // POST: api/Account/registration
        [HttpPost("registration")]
        public IActionResult Registration([FromForm]Account account)
        {
            return Ok(_accountService.Register(account));
        }
        // POST: api/Account/UpdateAccountProfile
        [HttpPost("UpdateAccountProfile")]
        public IActionResult UpdateAccountProfile([FromForm]Account account)
        {
            return Ok(_accountService.UpdateUserProfile(account));
        }
    }
    
}
