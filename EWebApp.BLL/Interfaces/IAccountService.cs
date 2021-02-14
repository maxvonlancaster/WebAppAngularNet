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

    }
}
