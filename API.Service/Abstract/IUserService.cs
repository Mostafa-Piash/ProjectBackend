using API.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API.Service.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<Users>> GetAllUsers();
        Task<Users> GetUser(int userId);
        Task<Users> AddUser(Users user);
        Task<Users> UpdateUser(Users user);
        Task<bool> RemoveUser(Users user);

    }
}
