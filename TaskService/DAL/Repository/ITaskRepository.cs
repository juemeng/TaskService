using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskService.DAL;

namespace TaskService.Repository
{
    public interface ITaskRepository:IRepository<Task>
    {
        IQueryable GetTasksByUser(User u);
        int GetLastTaskId();
    }
}
