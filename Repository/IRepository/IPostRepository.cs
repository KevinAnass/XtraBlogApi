using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;

namespace XtraBlogApi.Repository.IRepository
{
    public interface IPostRepository
    {
        public Task<List<PostCategories>> Posts();

        public Task<bool> DeletePost(int id);

        public Task<bool> UpdatePost(Post Post);

        public Task<bool> NewPost(Post Post);
    }
}
