using System;
using System.Collections.Generic;

#nullable disable

namespace XtraBlogApi.Models
{
    public partial class PostCategory
    {
        public int Id { get; set; }
        public int IdPost { get; set; }
        public int IdCategory { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Post IdPostNavigation { get; set; }
    }
}
