using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Activation;
using TaskService.Repository;
using TaskService.DAL;
using TaskService.Converter;
using System.Web;

namespace TaskService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TaskService" in code, svc and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Allowed)]
    public class TaskService : ITaskService
    {
        private IUserRepository _userRepository;
        private ITaskRepository _taskRepository;

        public TaskService(IUserRepository userRepository,ITaskRepository taskRepository)
        {
            _userRepository = userRepository;
            _taskRepository = taskRepository;
        }
        
        
        public bool CheckLogin(LoginRequest request)
        {
            var result = _userRepository.AuthenticUser(request.UserName, request.PassWord) != null;
            if (result)
            {
                HttpContext.Current.Session["UserName"] = request.PassWord;
            }
            return result;
        }

        public List<UserResponse> GetAllUser()
        {
            var list = new List<UserResponse>();
            _userRepository.All().ToList().ForEach(u=> list.Add(DataConverter.UserConvertToDTO(u)));
            return list;
        }

        public List<TaskResponse> GetAllTask()
        {
            var list = new List<TaskResponse>();
            _taskRepository.All().ToList().ForEach(t=> DataConverter.TaskConvertToDTO(t));
            return list;
        }
    }
}
