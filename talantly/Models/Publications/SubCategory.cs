using System;
using talantly.Models.Publications;

namespace talantly.Models
{
    public class SubCategory
    {
        public Guid id { get; set; }
        public Category category { get; set; }
        public String title { get; set; }
    }
}