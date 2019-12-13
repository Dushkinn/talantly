using System;

namespace talantly.Models
{
    public class Attachment
    {
        public Guid Id { get; set; }
        public AttachmentType attachmentType{ get; set;}
        public byte[] attachmentFile { get; set; }

    }
}