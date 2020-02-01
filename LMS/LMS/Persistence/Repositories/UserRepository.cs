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
        private static UserRepository instance = new UserRepository();

        public UserRepository(LibraryContext context)
        {
            _context = context;
        }

        public UserRepository() { }

        public static UserRepository getInstance()
        {
            return instance ?? (instance = new UserRepository(_context));
        }

        public void Add(Customer newUser)
        {
            _context.Customer.Add(newUser);
            _context.SaveChanges();
        }

        public void Delete(Customer user)
        {
            _context.Customer.Remove(user);
        }

        public UsersViewModel GetAll()
        {
            var query = _context.Customer.AsNoTracking();
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

        public Customer GetByID(int id)
        {
            return _context.Customer.AsNoTracking().FirstOrDefault(customer => customer.Id == id);
        }

        public Customer GetByUsername(string username)
        {
            return _context.Customer.AsNoTracking().FirstOrDefault(user => user.Username.Equals(username));
        }

        public void Update(Customer user)
        {
            _context.Customer.Update(user);
        }
        
    }
}
