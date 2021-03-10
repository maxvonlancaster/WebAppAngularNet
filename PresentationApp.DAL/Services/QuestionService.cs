using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PresentationApp.DAL.Services
{
    public class QuestionService : IService<Question>
    {
        private PresentationContext _presentationContext;

        public QuestionService(PresentationContext presentationContext)
        {
            _presentationContext = presentationContext;
        }

        public Task Add(Question entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> GetPage(int take, int skip, int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Question entity)
        {
            throw new NotImplementedException();
        }
    }
}
