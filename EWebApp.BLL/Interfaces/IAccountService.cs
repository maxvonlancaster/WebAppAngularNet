using EWebApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EWebApp.BLL.Interfaces
{
    public interface IAccountService
    {
        Task AddUser(User user);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByLogin(string email, string password);
        Task<List<User>> GetUsers(int skip, int take);
        Task DeleteUser(string email);
    }
}
