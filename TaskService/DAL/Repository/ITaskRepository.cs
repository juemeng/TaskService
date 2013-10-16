using System.Linq;

namespace TaskService.DAL.Repository
{
    public interface ITaskRepository:IRepository<Task>
    {
        IQueryable GetTasksByUser(User u);
        int GetLastTaskId();
    }
}
