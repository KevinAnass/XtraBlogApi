using System;
using System.Collections.Generic;

#nullable disable

namespace XtraBlogApi.Models
{
    public partial class Category
    {
        public Category()
        {
            PostCategories = new HashSet<PostCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PostCategory> PostCategories { get; set; }
    }
}
