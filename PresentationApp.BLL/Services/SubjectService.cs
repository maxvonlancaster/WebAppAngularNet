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
    public class SubjectService : IService<Subject>
    {
        private PresentationContext _presentationContext;

        public SubjectService(PresentationContext presentationContext)
        {
            _presentationContext = presentationContext;
        }

        public async Task Add(Subject entity)
        {
            await _presentationContext.Subjects.AddAsync(entity);
            await _presentationContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _presentationContext.Subjects.FirstOrDefaultAsync(x => x.Id == id);
            _presentationContext.Remove(entity);
            await _presentationContext.SaveChangesAsync();
        }

        public async Task<Subject> GetById(int id)
        {
            return await _presentationContext.Subjects.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Subject>> GetPage(int take, int skip, int id)
        {
            return await _presentationContext.Subjects
                .Where(p => p.User.Id == id)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task Update(Subject entity)
        {
            _presentationContext.Subjects.Update(entity);
            await _presentationContext.SaveChangesAsync();
        }
    }
}
