using System;
using System.Collections.Generic;
using talantly.Models.Publications;

namespace talantly.Models.User
{
    public class Profile
    {
        public Guid Id { get; set; }
        public Account account { get; set; }
        public String description { get; set; }
        public SubCategory SubCategory{ get; set;}
        public List<Attachment> attachmentsList { get; set; }
        public List<Publication> PublicationList { get; set; }

    }
}