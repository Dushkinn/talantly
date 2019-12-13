using System;
using System.Collections.Generic;

namespace talantly.Models
{
    public class Profile
    {
        public Guid Id { get; set; }
        public Account account { get; set; }
        public String description { get; set; }
        public SubCategory SubCategory{ get; set;}
        public List<Attachment> attachmentsList { get; set; }
        public List<Publication> publicationList { get; set; }
    }
}