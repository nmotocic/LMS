using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Persistence.Context;
using System.Collections.Generic;
using System.Linq;


namespace LMS.Persistence.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(LibraryContext context) : base(context)
        {
        }

        public void Add(User newUser)
        {
            _context.User.Add(newUser);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.User.Remove(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.User;
        }

        public User GetByID(int id)
        {
            return GetAll().FirstOrDefault(customer => customer.Id == id);
        }
        
        public void Update(User user)
        {
            _context.User.Update(user);
        }
        
    }
}
