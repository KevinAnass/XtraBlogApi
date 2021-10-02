using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;

namespace XtraBlogApi.Repository.IRepository
{
    public interface ICommentRepository
    {
        public Task<List<Comment>> Comments();

        public Task<bool> DeleteComment(int id);

        public Task<bool> UpdateComment(Comment comment);

        public Task<bool> NewComment(Comment comment);
    }
}
