﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("TaskModel", "FK_Task_User_Owner_Id", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(TaskService.DAL.User), "Task", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(TaskService.DAL.Task), true)]

#endregion

namespace TaskService.DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TaskEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TaskEntities object using the connection string found in the 'TaskEntities' section of the application configuration file.
        /// </summary>
        public TaskEntities() : base("name=TaskEntities", "TaskEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TaskEntities object.
        /// </summary>
        public TaskEntities(string connectionString) : base(connectionString, "TaskEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TaskEntities object.
        /// </summary>
        public TaskEntities(EntityConnection connection) : base(connection, "TaskEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Task> Tasks
        {
            get
            {
                if ((_Tasks == null))
                {
                    _Tasks = base.CreateObjectSet<Task>("Tasks");
                }
                return _Tasks;
            }
        }
        private ObjectSet<Task> _Tasks;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tasks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTasks(Task task)
        {
            base.AddObject("Tasks", task);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TaskModel", Name="Task")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Task : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Task object.
        /// </summary>
        /// <param name="taskId">Initial value of the TaskId property.</param>
        public static Task CreateTask(global::System.Int32 taskId)
        {
            Task task = new Task();
            task.TaskId = taskId;
            return task;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TaskId
        {
            get
            {
                return _TaskId;
            }
            set
            {
                if (_TaskId != value)
                {
                    OnTaskIdChanging(value);
                    ReportPropertyChanging("TaskId");
                    _TaskId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TaskId");
                    OnTaskIdChanged();
                }
            }
        }
        private global::System.Int32 _TaskId;
        partial void OnTaskIdChanging(global::System.Int32 value);
        partial void OnTaskIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TaskName
        {
            get
            {
                return _TaskName;
            }
            set
            {
                OnTaskNameChanging(value);
                ReportPropertyChanging("TaskName");
                _TaskName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TaskName");
                OnTaskNameChanged();
            }
        }
        private global::System.String _TaskName;
        partial void OnTaskNameChanging(global::System.String value);
        partial void OnTaskNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Time
        {
            get
            {
                return _Time;
            }
            set
            {
                OnTimeChanging(value);
                ReportPropertyChanging("Time");
                _Time = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Time");
                OnTimeChanged();
            }
        }
        private global::System.String _Time;
        partial void OnTimeChanging(global::System.String value);
        partial void OnTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Owner_Id
        {
            get
            {
                return _Owner_Id;
            }
            set
            {
                OnOwner_IdChanging(value);
                ReportPropertyChanging("Owner_Id");
                _Owner_Id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Owner_Id");
                OnOwner_IdChanged();
            }
        }
        private Nullable<global::System.Int32> _Owner_Id;
        partial void OnOwner_IdChanging(Nullable<global::System.Int32> value);
        partial void OnOwner_IdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TaskModel", "FK_Task_User_Owner_Id", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("TaskModel.FK_Task_User_Owner_Id", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("TaskModel.FK_Task_User_Owner_Id", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("TaskModel.FK_Task_User_Owner_Id", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("TaskModel.FK_Task_User_Owner_Id", "User", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TaskModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="isAdmin">Initial value of the IsAdmin property.</param>
        public static User CreateUser(global::System.Int32 id, global::System.Boolean isAdmin)
        {
            User user = new User();
            user.Id = id;
            user.IsAdmin = isAdmin;
            return user;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PassWord
        {
            get
            {
                return _PassWord;
            }
            set
            {
                OnPassWordChanging(value);
                ReportPropertyChanging("PassWord");
                _PassWord = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PassWord");
                OnPassWordChanged();
            }
        }
        private global::System.String _PassWord;
        partial void OnPassWordChanging(global::System.String value);
        partial void OnPassWordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String IconUrl
        {
            get
            {
                return _IconUrl;
            }
            set
            {
                OnIconUrlChanging(value);
                ReportPropertyChanging("IconUrl");
                _IconUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("IconUrl");
                OnIconUrlChanged();
            }
        }
        private global::System.String _IconUrl;
        partial void OnIconUrlChanging(global::System.String value);
        partial void OnIconUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAdmin
        {
            get
            {
                return _IsAdmin;
            }
            set
            {
                OnIsAdminChanging(value);
                ReportPropertyChanging("IsAdmin");
                _IsAdmin = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAdmin");
                OnIsAdminChanged();
            }
        }
        private global::System.Boolean _IsAdmin;
        partial void OnIsAdminChanging(global::System.Boolean value);
        partial void OnIsAdminChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TaskModel", "FK_Task_User_Owner_Id", "Task")]
        public EntityCollection<Task> Tasks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Task>("TaskModel.FK_Task_User_Owner_Id", "Task");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Task>("TaskModel.FK_Task_User_Owner_Id", "Task", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}