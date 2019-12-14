using System;
namespace talantly.Models.User
{
    public class ProfilePriority
    {
        public ProfilePriority()
        {
        }

        public Guid Id { get; set; }
        public Profile profile { get;set; }
        public int priority { get; set; }
    }
}
