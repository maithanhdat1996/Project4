﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialFashion.Model.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SocialFashionDbContext : DbContext
    {
        public SocialFashionDbContext()
            : base("name=SocialFashionDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Branch> Branchs { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusComment> StatusComments { get; set; }
        public virtual DbSet<StatusLike> StatusLikes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Fan> Fans { get; set; }
    
        public virtual ObjectResult<GetAllProductByCat_Result> GetAllProductByCat(Nullable<int> catid)
        {
            var catidParameter = catid.HasValue ?
                new ObjectParameter("Catid", catid) :
                new ObjectParameter("Catid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllProductByCat_Result>("GetAllProductByCat", catidParameter);
        }
    
        public virtual ObjectResult<GetAllProduct_Result> GetAllProduct()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllProduct_Result>("GetAllProduct");
        }
    
        public virtual ObjectResult<GetAllStutusByUserId_Result> GetAllStutusByUserId(string userId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllStutusByUserId_Result>("GetAllStutusByUserId", userIdParameter);
        }
    
        public virtual ObjectResult<Users_List_Result> Users_List()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Users_List_Result>("Users_List");
        }
    
        public virtual ObjectResult<Fans_GetFanByUser_Result> Fans_GetFanByUser(string userId, string fanId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var fanIdParameter = fanId != null ?
                new ObjectParameter("FanId", fanId) :
                new ObjectParameter("FanId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Fans_GetFanByUser_Result>("Fans_GetFanByUser", userIdParameter, fanIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Fans_Insert(string senderId, string requestId, Nullable<short> status, string message)
        {
            var senderIdParameter = senderId != null ?
                new ObjectParameter("SenderId", senderId) :
                new ObjectParameter("SenderId", typeof(string));
    
            var requestIdParameter = requestId != null ?
                new ObjectParameter("RequestId", requestId) :
                new ObjectParameter("RequestId", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(short));
    
            var messageParameter = message != null ?
                new ObjectParameter("Message", message) :
                new ObjectParameter("Message", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Fans_Insert", senderIdParameter, requestIdParameter, statusParameter, messageParameter);
        }
    
        public virtual ObjectResult<AspNetUsers_CheckAddFriend_Result> AspNetUsers_CheckAddFriend(string requestId)
        {
            var requestIdParameter = requestId != null ?
                new ObjectParameter("RequestId", requestId) :
                new ObjectParameter("RequestId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AspNetUsers_CheckAddFriend_Result>("AspNetUsers_CheckAddFriend", requestIdParameter);
        }
    
        public virtual ObjectResult<Users_GetById_Result> Users_GetById(string userId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Users_GetById_Result>("Users_GetById", userIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Fans_Update(string senderId, string requestId, string replyStatus)
        {
            var senderIdParameter = senderId != null ?
                new ObjectParameter("SenderId", senderId) :
                new ObjectParameter("SenderId", typeof(string));
    
            var requestIdParameter = requestId != null ?
                new ObjectParameter("RequestId", requestId) :
                new ObjectParameter("RequestId", typeof(string));
    
            var replyStatusParameter = replyStatus != null ?
                new ObjectParameter("ReplyStatus", replyStatus) :
                new ObjectParameter("ReplyStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Fans_Update", senderIdParameter, requestIdParameter, replyStatusParameter);
        }
    }
}
