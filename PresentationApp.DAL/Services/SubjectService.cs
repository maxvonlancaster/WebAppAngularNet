using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PresentationApp.DAL.Services
{
    public class SubjectService : IService<Subject>
    {
        private PresentationContext _presentationContext;

        public SubjectService(PresentationContext presentationContext)
        {
            _presentationContext = presentationContext;
        }

        public Task Add(Subject entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Subject> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Subject>> GetPage(int take, int skip, int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Subject entity)
        {
            throw new NotImplementedException();
        }
    }
}
