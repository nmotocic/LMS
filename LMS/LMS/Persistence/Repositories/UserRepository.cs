using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;
using LMS.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace LMS.Persistence.Repositories
{
    public class UserRepository :  IUserRepository
    {
        protected static LibraryContext _context = new LibraryContext();
        public UserRepository(LibraryContext context)
        {
            _context = context;
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

        public UsersViewModel GetAll()
        {
            var query = _context.User.AsNoTracking();
            var users = query.Select(user => new UserViewModel
            {
                User_ID = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Phone = user.Phone,
                Username = user.Username
            }).ToList();
            var model = new UsersViewModel { Users = users };
            return model;
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
