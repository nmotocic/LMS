using LMS.Domain.Models;
using LMS.Domain.ViewModels;

namespace LMS.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetByID(int id);
        UsersViewModel GetAll();

        void Add(User newUser);
        void Update(User user);
        void Delete(User user);
    }
}
