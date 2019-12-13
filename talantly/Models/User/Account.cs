using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace talantly.Models
{
    public class Account
    {
        public Guid id { get; set; }
        public String login { get; set; }
        public AccountRole accountRole { get; set; }
        public String eMail { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public byte[] Img { get; set; }
        public List<Profile> ProfileList { get; set; } 
       
    }
}
