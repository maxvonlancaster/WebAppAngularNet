using EWebApp.BLL.Interfaces;
using EWebApp.DAL.Context;
using EWebApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebApp.BLL.Services
{
    public class AccountService : IAccountService
    {
        private PresentationContext _dbContext;

        public AccountService(PresentationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddUser(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(string email)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }

        public async Task<User> GetUserByLogin(string email, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            return user;
        }

        public async Task<List<User>> GetUsers(int skip, int take)
        {
            var users = await _dbContext.Users.Skip(skip).Take(take).ToListAsync();
            return users;
        }
    }
}
