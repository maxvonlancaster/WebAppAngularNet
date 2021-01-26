using EWebApp.BLL.Exceptions;
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
    public class PresentationService : IPresentationService
    {
        private readonly PresentationContext _context;

        public PresentationService(PresentationContext context)
        {
            _context = context;
        }

        public async Task<Presentation> DeletePresentation(long id)
        {
            var presentation = await _context.Presentations.FindAsync(id);
            if (presentation == null)
            {
                throw new ItemNotFoundEsception("Presentation not found");
            }

            _context.Presentations.Remove(presentation);
            await _context.SaveChangesAsync();

            return presentation;
        }

        public async Task<Presentation> GetPresentation(long id)
        {
            var presentation = await _context.Presentations.FindAsync(id);

            if (presentation == null)
            {
                throw new ItemNotFoundEsception("Presentation not found");
            }

            return presentation;
        }

        public async Task<IEnumerable<Presentation>> GetPresentations(int offset, int count)
        {
            return await _context.Presentations.Skip(offset).Take(count)
                .Select(p => new Presentation 
                { 
                    PresentationId = p.PresentationId, 
                    PresentationName = p.PresentationName, 
                    PresentationTopic = p.PresentationTopic 
                })
                .ToListAsync();
        }

        public async Task PostPresentation(Presentation presentation)
        {
            if (presentation.PresentationId == 0)
            {
                _context.Presentations.Add(presentation);
            }
            else 
            {
                _context.Presentations.Update(presentation);
            }
            await _context.SaveChangesAsync();
        }

        public async Task PutPresentation(long id, Presentation presentation)
        {
            if (id != presentation.PresentationId)
            {
                throw new BadRequestException("Presentation is invalid");
            }

            _context.Entry(presentation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PresentationExists(id))
                {
                    throw new ItemNotFoundEsception("Presentation not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public bool PresentationExists(long id)
        {
            throw new NotImplementedException();
        }
    }
}
