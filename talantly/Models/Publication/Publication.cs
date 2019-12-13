using System;
using System.Collections.Generic;

namespace talantly.Models
{
    public class Publication
    {
        public Publication()
        {
        }
        public Guid Id { get; set; }
        public String description { get; set; }
        public List<Attachment> attachmentList { get; set; }



    }
}
