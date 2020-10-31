using EWebApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EWebApp.BLL.Interfaces
{
    public interface IPresentationService
    {
        Task<IEnumerable<Presentation>> GetPresentations(int offset, int count);
        Task<Presentation> GetPresentation(long id);
        Task PostPresentation(Presentation presentation);
        Task<Presentation> DeletePresentation(long id);
        Task PutPresentation(long id, Presentation presentation);
        bool PresentationExists(long id);
    }
}
