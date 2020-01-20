using API.Data.Model;
using API.Repository.Abstract;
using API.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API.Service.Concrete
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Users> AddUser(Users user)
        {
            try
            {
                return await _repository.AddUser(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            try
            {
                return await _repository.GetAllUsers();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Users> GetUser(int userId)
        {
            try
            {
                return await _repository.GetUser(userId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> RemoveUser(Users user)
        {
            try
            {
                return await _repository.RemoveUser(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Users> UpdateUser(Users user)
        {
            try
            {
                return await _repository.UpdateUser(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
