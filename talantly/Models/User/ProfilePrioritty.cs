using System;
namespace talantly.Models.User
{
    public class EmptyClass
    {
        public EmptyClass()
        {
        }

        public Guid Id { get; set; }
        public Profile profile { get;set; }
        public int priority { get; set; }
    }
}
