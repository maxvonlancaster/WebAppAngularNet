using Microsoft.EntityFrameworkCore;
using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationApp.DAL.Services
{
    public class PresentationService : IService<Presentation>
    {
        private PresentationContext _presentationContext;

        public PresentationService(PresentationContext presentationContext)
        {
            _presentationContext = presentationContext;
        }

        public async Task Add(Presentation entity)
        {
            await _presentationContext.Presentations.AddAsync(entity);
            await _presentationContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _presentationContext.Presentations.FirstOrDefaultAsync(x => x.Id == id);
            _presentationContext.Remove(entity);
            await _presentationContext.SaveChangesAsync();
        }

        public async Task<Presentation> GetById(int id)
        {
            return await _presentationContext.Presentations.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Presentation>> GetPage(int take, int skip, int id)
        {
            return await _presentationContext.Presentations
                .Where(p => p.Subject.Id == id)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task Update(Presentation entity)
        {
            _presentationContext.Presentations.Update(entity);
            await _presentationContext.SaveChangesAsync();
        }
    }
}
