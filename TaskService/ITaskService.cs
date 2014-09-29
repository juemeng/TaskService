using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TaskService.DAL;


namespace TaskService
{
    [ServiceContract(SessionMode=SessionMode.Allowed)]
    public interface ITaskService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Login", Method = "POST")]
        bool CheckLogin(LoginRequest request);

        [OperationContract]
        [WebGet(UriTemplate = "Users")]
        List<UserResponse> GetAllUser();

        [OperationContract]
        [WebGet(UriTemplate = "Tasks")]
        List<TaskResponse> GetAllTask();

        [OperationContract]
        [WebInvoke(UriTemplate = "ADLogin", Method = "POST")]
        ADLoginResponse ADLogin(LoginRequest request);
    }

    #region DataContract

    [DataContract]
    public class LoginRequest
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string PassWord { get; set; }
    }

    [DataContract]
    public class ADLoginResponse
    {
        [DataMember]
        public string UserKey { get; set; }
        [DataMember]
        public ADUser User { get; set; }
    }

    [DataContract]
    public class ADUser
    {
        [DataMember]
        public string Anvandarnamn { get; set; }
        [DataMember]
        public Guid MedlemsorganisationID { get; set; }
        [DataMember]
        public string MedlemsorganisationNamn { get; set; }
        [DataMember]
        public string MoGrupp { get; set; }
        [DataMember]
        public Guid MoGruppID { get; set; }
        [DataMember]
        public Guid SystemUserID { get; set; }
    }

    [DataContract]
    public class TaskResponse
    {
        [DataMember]
        public int Taskid { get; set; }
        [DataMember]
        public string Taskname { get; set; }
        [DataMember]
        public string Taskdetails { get; set; }
        [DataMember]
        public string Time { get; set; }
        [DataMember]
        public int? Ownerid { get; set; }
    }

    [DataContract]
    public class UserResponse
    {
        [DataMember]
        public int Userid { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string PassWord { get; set; }
        [DataMember]
        public string Iconurl { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public bool IsAdmin { get; set; }
    }

    #endregion

}
