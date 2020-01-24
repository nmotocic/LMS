using LMS.Domain.Models;
using LMS.Domain.ViewModels;

namespace LMS.Domain.Repositories
{
    public interface IUserRepository
    {
        Customer GetByID(int id);
        UsersViewModel GetAll();

        void Add(Customer newUser);
        void Update(Customer user);
        void Delete(Customer user);
        Customer GetByUsername(string username);
    }
}
