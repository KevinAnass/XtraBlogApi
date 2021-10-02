using System;
using System.Collections.Generic;

#nullable disable

namespace XtraBlogApi.Models
{
    public partial class Post
    {
        public Post()
        {
            PostCategories = new HashSet<PostCategory>();
            PostComments = new HashSet<PostComment>();
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime? Time { get; set; }
        public string Link { get; set; }
        public string Picture { get; set; }
        public string Title { get; set; }
        public int? IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<PostCategory> PostCategories { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; }
    }
}
