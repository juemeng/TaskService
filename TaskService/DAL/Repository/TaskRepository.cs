using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;
using TaskService.DAL;
using TaskService.DAL.Repository;

namespace TaskService.Repository
{
//    public class TaskRepository:ITaskRepository
//    {
//        private TaskEntities _context;
//
//        public TaskRepository(TaskEntities context)
//        {
//            _context = context;
//        }
//
//        public IQueryable GetTasksByUser(User u)
//        {
//            return _context.Tasks.Where(t =>t.Owner_Id == u.Id);
//        }
//
//        public IQueryable<Task> All(Func<Task, bool> func = null)
//        {
//            if (func != null)
//            {
//                return _context.Tasks.Where(func).AsQueryable();
//            }
//            else
//            {
//                return _context.Tasks.Include(t => t.User);
//            }
//        }
//
//        public Task Find(int id)
//        {
//            return _context.Tasks.SingleOrDefault(t => t.TaskId == id);
//        }
//
//        public void InsertOrUpdate(Task t)
//        {
//            if (t.TaskId == default(int))
//            {
//                _context.Tasks.AddObject(t);
//            }
//            else
//            {
//                var task = Find(t.TaskId);
//                task.TaskName = t.TaskName;
//                task.Owner_Id = t.Owner_Id;
//                task.Description = t.Description;
//                task.Time = t.Time;
//            }
//        }
//
//        public void Delete(int id)
//        {
//            var task = Find(id);
//            _context.Tasks.DeleteObject(task);
//        }
//
//        public void Save()
//        {
//            _context.SaveChanges();
//        }
//
//        public int GetLastTaskId()
//        {
//            return _context.Tasks.Max(t => t.TaskId);
//        }
//
//    }
}