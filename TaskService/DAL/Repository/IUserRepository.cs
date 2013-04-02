using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskService.DAL;

namespace TaskService.Repository
{
    public interface IUserRepository:IRepository<User>
    {
        void DeleteTask(User user);
        User AuthenticUser(string username, string password);
        User FindUserByName(string username);
        int GetLastUserId();
        List<string> GetNames();
    }
}
