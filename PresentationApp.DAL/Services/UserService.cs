using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PresentationApp.DAL.Services
{
    public class UserService : IService<User>
    {
        private PresentationContext _presentationContext;

        public UserService(PresentationContext presentationContext)
        {
            _presentationContext = presentationContext;
        }

        public Task Add(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetPage(int take, int skip, int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
