using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskService.DAL;

namespace TaskService.Repository
{
//    public class UserRepository:IUserRepository
//    {
//        private TaskEntities _context;
//
//        public UserRepository(TaskEntities context)
//        {
//            _context = context;
//        }
//        
//        public void DeleteTask(User user)
//        {
//            user.Tasks.ToList().ForEach(t => _context.Tasks.DeleteObject(t));
//        }
//
//        public User AuthenticUser(string username, string password)
//        {
//            return _context.Users.SingleOrDefault(u => u.Name == username && u.PassWord == password);
//        }
//
//        public User FindUserByName(string username)
//        {
//            return _context.Users.SingleOrDefault(u => u.Name == username);
//        }
//
//        public IQueryable<User> All(Func<User, bool> func = null)
//        {
//            if (func != null)
//            {
//                return _context.Users.Where(func).AsQueryable();
//            }
//            else
//            {
//                return _context.Users;
//            }
//        }
//
//        public User Find(int id)
//        {
//            return _context.Users.SingleOrDefault(u => u.Id == id);
//        }
//
//        public void InsertOrUpdate(User user)
//        {
//            if (user.Id == default(int))
//            {
//                _context.Users.AddObject(user);
//            }
//            else
//            {
//                var u = Find(user.Id);
//                u.Name = user.Name;
//                u.Email = user.Email;
//                u.PassWord = u.PassWord;
//                u.IconUrl = user.IconUrl;
//            }
//        }
//
//        public void Delete(int id)
//        {
//            var user = Find(id);
//            DeleteTask(user);
//            _context.Users.DeleteObject(user);
//        }
//
//        public void Save()
//        {
//            _context.SaveChanges();
//        }
//
//        public int GetLastUserId()
//        {
//            return _context.Users.Max(u => u.Id);
//        }
//
//        public List<string> GetNames()
//        {
//            return _context.Users.Select(u => u.Name).ToList();
//        }
//    }
}