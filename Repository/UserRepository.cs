using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;
using XtraBlogApi.Repository.IRepository;

namespace XtraBlogApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private DataContext Context;

        public UserRepository(DataContext con)
        {
            Context = con;
        }

        public async Task<List<User>> Users()
        {
            try
            {
                return await Context.Users.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        public async Task<bool> DeleteUser(int id)
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

        public async Task<bool> NewUser(User User)
        {
            try
            {
                if (await Context.Users.AnyAsync(x => x.Email == User.Email))
                    return false;
                User.Id = Context.Users.Any() ? (await Context.Users.MaxAsync(x => x.Id)) + 1 : 1;
                await Context.Users.AddAsync(User);
                await Context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> UpdateUser(User User)
        {
            try
            {
                Context.Users.Update(User);
                await Context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> User(string email, string password)
        {
            try
            {
                if (await Context.Users.AnyAsync())
                {
                    if (Context.Users.First(x => x.Email == email && x.Password == password) != null)
                        return true;
                    return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
