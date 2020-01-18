using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetByID(int id);
        IEnumerable<User> GetAll();

        void Add(User newUser);
        void Update(User user);
        void Delete(User user);
    }
}
