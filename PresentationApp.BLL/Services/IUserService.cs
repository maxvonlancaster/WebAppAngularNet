using PresentationApp.DAL.Entities;
using System.Threading.Tasks;

namespace PresentationApp.BLL.Services
{
    public interface IUserService : IService<User>
    {
        Task<User> GetByUserName(string userName);
        Task<User> Login(string userName, string password);
    }
}
