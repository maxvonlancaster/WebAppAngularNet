using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PresentationApp.BLL.Services
{
    public interface IService<T> where T : IEntity
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetPage(int take, int skip, int id);
        Task Delete(int id);
        Task Add(T entity);
        Task Update(T entity);
    }
}
