using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XtraBlogApi.Models
{
    public class PostCategories
    {
        public List<Category> Categories{ get; set; }
        public Post Post { get; set; }
        public int Comments { get; set; }
    }
}
