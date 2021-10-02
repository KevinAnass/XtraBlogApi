using System;
using System.Collections.Generic;

#nullable disable

namespace XtraBlogApi.Models
{
    public partial class PostComment
    {
        public int Id { get; set; }
        public int? IdPost { get; set; }
        public int? IdComment { get; set; }

        public virtual Comment IdCommentNavigation { get; set; }
        public virtual Post IdPostNavigation { get; set; }
    }
}
