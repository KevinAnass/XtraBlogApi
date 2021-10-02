using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;
using XtraBlogApi.Repository.IRepository;

namespace XtraBlogApi.Repository
{
    public class CommentRepository: ICommentRepository
    {
        private DataContext Context;

        public CommentRepository(DataContext con)
        {
            Context = con;
        }

        public async Task<List<Comment>> Comments()
        {
            try
            {
                return await Context.Comments.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> DeleteComment(int id)
        {
            try
            {
                Context.Categories.Remove(Context.Categories.First(x => x.Id == id));
                await Context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> NewComment(Comment Comment)
        {
            try
            {
                await Context.Comments.AddAsync(Comment);
                await Context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> UpdateComment(Comment Comment)
        {
            try
            {
                Context.Comments.Update(Comment);
                await Context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
