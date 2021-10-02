using System;
using System.Collections.Generic;

#nullable disable

namespace XtraBlogApi.Models
{
    public partial class Comment
    {
        public Comment()
        {
            PostComments = new HashSet<PostComment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime? Time { get; set; }
        public int? IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; }
    }
}
