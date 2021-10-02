using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;
using XtraBlogApi.Repository.IRepository;
namespace XtraBlogApi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext Context;

        public CategoryRepository(DataContext con)
        {
            Context = con;
        }

        public async Task<List<Category>> Categories()
        {
            try
            {
                return await Context.Categories.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> DeleteCategory(int id)
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

        public async Task<bool> NewCategory(Category category)
        {
            try
            {
                await Context.Categories.AddAsync(category);
                await Context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            try
            {
                Context.Categories.Update(category);
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
