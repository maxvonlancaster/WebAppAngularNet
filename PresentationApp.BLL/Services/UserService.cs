using Microsoft.EntityFrameworkCore;
using PresentationApp.DAL;
using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationApp.BLL.Services
{
    public class UserService : IUserService
    {
        private PresentationContext _presentationContext;

        public UserService(PresentationContext presentationContext)
        {
            _presentationContext = presentationContext;
        }

        public async Task Add(User entity)
        {
            await _presentationContext.Users.AddAsync(entity);
            await _presentationContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _presentationContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            _presentationContext.Remove(entity);
            await _presentationContext.SaveChangesAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _presentationContext.Users.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<User>> GetPage(int take, int skip, int id = 0)
        {
            return await _presentationContext.Users
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task<User> Login(string userName, string password)
        {
            return await _presentationContext.Users
                .FirstOrDefaultAsync(p => p.UserName == userName && p.Password == password);
        }

        public async Task<User> GetByUserName(string userName)
        {
            return await _presentationContext.Users
                .FirstOrDefaultAsync(p => p.UserName == userName);
        }

        public async Task Update(User entity)
        {
            _presentationContext.Users.Update(entity);
            await _presentationContext.SaveChangesAsync();
        }
    }
}
