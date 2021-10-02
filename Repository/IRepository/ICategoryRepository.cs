using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;

namespace XtraBlogApi.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> Categories();

        public Task<bool> DeleteCategory(int id);

        public Task<bool> UpdateCategory(Category category);

        public Task<bool> NewCategory(Category category);

    }
}
