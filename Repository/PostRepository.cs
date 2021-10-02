using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;
using XtraBlogApi.Repository.IRepository;

namespace XtraBlogApi.Repository
{
    public class PostRepository: IPostRepository
    {
        private DataContext Context;

        public PostRepository(DataContext con)
        {
            Context = con;
        }

        public async Task<List<Post>> Posts()
        {
            try
            {
                return await Context.Posts.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> DeletePost(int id)
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

        public async Task<bool> NewPost(Post Post)
        {
            try
            {
                await Context.Posts.AddAsync(Post);
                await Context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> UpdatePost(Post Post)
        {
            try
            {
                Context.Posts.Update(Post);
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
