using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using talantly.Models.User;

namespace talantly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {



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

        // DELETE: api/Account/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        // POST: api/Account/login
        [HttpPost("login")]
        public IActionResult LogIn( String login ,  String password)
        {
            if (login == "Damir" && password == "12345")
            {
                return Ok(new Answer (true));
            }
            else
            {
                return Ok(new Answer (false));
            }
        }
        // POST: api/Account/registration
        [HttpPost("registration")]
        public Boolean Registration(Account account)
        {
            if (account.login == "Damir" && account.password == "12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class Answer {
        public Answer(Boolean answer) 
        {
            this.answer = answer;
        }
        public Boolean answer { get; set; }
    }
}
