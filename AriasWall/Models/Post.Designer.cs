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
namespace AriasWall.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AriasWallDBEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AriasWallDBEntities1 object using the connection string found in the 'AriasWallDBEntities1' section of the application configuration file.
        /// </summary>
        public AriasWallDBEntities1() : base("name=AriasWallDBEntities1", "AriasWallDBEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AriasWallDBEntities1 object.
        /// </summary>
        public AriasWallDBEntities1(string connectionString) : base(connectionString, "AriasWallDBEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AriasWallDBEntities1 object.
        /// </summary>
        public AriasWallDBEntities1(EntityConnection connection) : base(connection, "AriasWallDBEntities1")
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
        public ObjectSet<Post> Posts
        {
            get
            {
                if ((_Posts == null))
                {
                    _Posts = base.CreateObjectSet<Post>("Posts");
                }
                return _Posts;
            }
        }
        private ObjectSet<Post> _Posts;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Posts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPosts(Post post)
        {
            base.AddObject("Posts", post);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AriasWallDBModel", Name="Post")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Post : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Post object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="author">Initial value of the author property.</param>
        /// <param name="date">Initial value of the date property.</param>
        public static Post CreatePost(global::System.Int32 id, global::System.String author, global::System.DateTime date)
        {
            Post post = new Post();
            post.Id = id;
            post.author = author;
            post.date = date;
            return post;
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String author
        {
            get
            {
                return _author;
            }
            set
            {
                OnauthorChanging(value);
                ReportPropertyChanging("author");
                _author = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("author");
                OnauthorChanged();
            }
        }
        private global::System.String _author;
        partial void OnauthorChanging(global::System.String value);
        partial void OnauthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.DateTime _date;
        partial void OndateChanging(global::System.DateTime value);
        partial void OndateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String message
        {
            get
            {
                return _message;
            }
            set
            {
                OnmessageChanging(value);
                ReportPropertyChanging("message");
                _message = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("message");
                OnmessageChanged();
            }
        }
        private global::System.String _message;
        partial void OnmessageChanging(global::System.String value);
        partial void OnmessageChanged();

        #endregion

    
    }

    #endregion

    
}
