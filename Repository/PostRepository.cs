using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;
using XtraBlogApi.Repository.IRepository;

namespace XtraBlogApi.Repository
{
    public class PostRepository : IPostRepository
    {
        private DataContext Context;

        public PostRepository(DataContext con)
        {
            Context = con;
        }

        public async Task<List<PostCategories>> Posts()
        {
            try
            {
                List<PostCategories> pcs = new List<PostCategories>();
                (await Context.Posts.Include(x => x.PostCategories).Include(x=>x.PostComments).ToListAsync()).ForEach(post=>
                {
                    pcs.Add(new PostCategories
                    {
                        Post = post,
                        Categories = Context.Categories.Where(x => post.PostCategories.Select(y => y.IdCategory).Contains(x.Id)).ToList()
                    });
                });

                return pcs;
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
