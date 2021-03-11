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
    public class QuestionService : IService<Question>
    {
        private PresentationContext _presentationContext;

        public QuestionService(PresentationContext presentationContext)
        {
            _presentationContext = presentationContext;
        }

        public async Task Add(Question entity)
        {
            await _presentationContext.Questions.AddAsync(entity);
            await _presentationContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _presentationContext.Questions.FirstOrDefaultAsync(x => x.Id == id);
            _presentationContext.Remove(entity);
            await _presentationContext.SaveChangesAsync();
        }

        public async Task<Question> GetById(int id)
        {
            return await _presentationContext.Questions.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Question>> GetPage(int take, int skip, int id)
        {
            return await _presentationContext.Questions
                .Where(p => p.Presentation.Id == id)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task Update(Question entity)
        {
            _presentationContext.Questions.Update(entity);
            await _presentationContext.SaveChangesAsync();
        }
    }
}
