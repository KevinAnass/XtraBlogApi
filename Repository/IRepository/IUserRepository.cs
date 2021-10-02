using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;

namespace XtraBlogApi.Repository.IRepository
{
    public interface IUserRepository
    {
        public Task<List<User>> Users();

        public Task<bool> DeleteUser(int id);

        public Task<bool> UpdateUser(User User);

        public Task<bool> NewUser(User User);
    }
}
