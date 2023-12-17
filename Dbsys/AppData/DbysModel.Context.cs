﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dbsys.AppData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DBSYSEntities : DbContext
    {
        public DBSYSEntities()
            : base("name=DBSYSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vw_all_user_role> vw_all_user_role { get; set; }
        public DbSet<vw_ShowtimeDetails> vw_ShowtimeDetails { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Showtimes> Showtimes { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<UserInformation> UserInformation { get; set; }
    
        public virtual int sp_newUser(string userName, string userPassword, Nullable<int> roleId, Nullable<int> createdBy)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("roleId", roleId) :
                new ObjectParameter("roleId", typeof(int));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("createdBy", createdBy) :
                new ObjectParameter("createdBy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_newUser", userNameParameter, userPasswordParameter, roleIdParameter, createdByParameter);
        }
    
        public virtual int sp_UpdateUser(Nullable<int> userId, string userName, string userPassword)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateUser", userIdParameter, userNameParameter, userPasswordParameter);
        }
    
        public virtual int sp_UpdatedUser(Nullable<int> userId, string userName, string userPassword)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdatedUser", userIdParameter, userNameParameter, userPasswordParameter);
        }
    
        public virtual int sp_UpdateUsers(Nullable<int> userId, string userName, string userPassword, Nullable<int> roleId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("roleId", roleId) :
                new ObjectParameter("roleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateUsers", userIdParameter, userNameParameter, userPasswordParameter, roleIdParameter);
        }
    
        public virtual int sp_UpdateShowtime(Nullable<int> showtimeID, Nullable<int> movieID, Nullable<System.DateTime> showDate, Nullable<System.TimeSpan> startTime, Nullable<System.TimeSpan> endTime, Nullable<int> capacity)
        {
            var showtimeIDParameter = showtimeID.HasValue ?
                new ObjectParameter("ShowtimeID", showtimeID) :
                new ObjectParameter("ShowtimeID", typeof(int));
    
            var movieIDParameter = movieID.HasValue ?
                new ObjectParameter("MovieID", movieID) :
                new ObjectParameter("MovieID", typeof(int));
    
            var showDateParameter = showDate.HasValue ?
                new ObjectParameter("ShowDate", showDate) :
                new ObjectParameter("ShowDate", typeof(System.DateTime));
    
            var startTimeParameter = startTime.HasValue ?
                new ObjectParameter("StartTime", startTime) :
                new ObjectParameter("StartTime", typeof(System.TimeSpan));
    
            var endTimeParameter = endTime.HasValue ?
                new ObjectParameter("EndTime", endTime) :
                new ObjectParameter("EndTime", typeof(System.TimeSpan));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("Capacity", capacity) :
                new ObjectParameter("Capacity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateShowtime", showtimeIDParameter, movieIDParameter, showDateParameter, startTimeParameter, endTimeParameter, capacityParameter);
        }
    
        public virtual int sp_InsertShowtime(Nullable<int> movieID, Nullable<System.DateTime> showDate, Nullable<System.TimeSpan> startTime, Nullable<System.TimeSpan> endTime, Nullable<int> capacity)
        {
            var movieIDParameter = movieID.HasValue ?
                new ObjectParameter("MovieID", movieID) :
                new ObjectParameter("MovieID", typeof(int));
    
            var showDateParameter = showDate.HasValue ?
                new ObjectParameter("ShowDate", showDate) :
                new ObjectParameter("ShowDate", typeof(System.DateTime));
    
            var startTimeParameter = startTime.HasValue ?
                new ObjectParameter("StartTime", startTime) :
                new ObjectParameter("StartTime", typeof(System.TimeSpan));
    
            var endTimeParameter = endTime.HasValue ?
                new ObjectParameter("EndTime", endTime) :
                new ObjectParameter("EndTime", typeof(System.TimeSpan));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("Capacity", capacity) :
                new ObjectParameter("Capacity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertShowtime", movieIDParameter, showDateParameter, startTimeParameter, endTimeParameter, capacityParameter);
        }
    
        public virtual int sp_InsertShowtimes(Nullable<int> movieID, Nullable<System.DateTime> showDate, Nullable<System.TimeSpan> startTime, Nullable<System.TimeSpan> endTime, Nullable<int> capacity)
        {
            var movieIDParameter = movieID.HasValue ?
                new ObjectParameter("MovieID", movieID) :
                new ObjectParameter("MovieID", typeof(int));
    
            var showDateParameter = showDate.HasValue ?
                new ObjectParameter("ShowDate", showDate) :
                new ObjectParameter("ShowDate", typeof(System.DateTime));
    
            var startTimeParameter = startTime.HasValue ?
                new ObjectParameter("StartTime", startTime) :
                new ObjectParameter("StartTime", typeof(System.TimeSpan));
    
            var endTimeParameter = endTime.HasValue ?
                new ObjectParameter("EndTime", endTime) :
                new ObjectParameter("EndTime", typeof(System.TimeSpan));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("Capacity", capacity) :
                new ObjectParameter("Capacity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertShowtimes", movieIDParameter, showDateParameter, startTimeParameter, endTimeParameter, capacityParameter);
        }
    
        public virtual int sp_UpdateShowtimes(Nullable<int> showtimeID, Nullable<int> movieID, Nullable<System.DateTime> showDate, Nullable<System.TimeSpan> startTime, Nullable<System.TimeSpan> endTime, Nullable<int> capacity)
        {
            var showtimeIDParameter = showtimeID.HasValue ?
                new ObjectParameter("ShowtimeID", showtimeID) :
                new ObjectParameter("ShowtimeID", typeof(int));
    
            var movieIDParameter = movieID.HasValue ?
                new ObjectParameter("MovieID", movieID) :
                new ObjectParameter("MovieID", typeof(int));
    
            var showDateParameter = showDate.HasValue ?
                new ObjectParameter("ShowDate", showDate) :
                new ObjectParameter("ShowDate", typeof(System.DateTime));
    
            var startTimeParameter = startTime.HasValue ?
                new ObjectParameter("StartTime", startTime) :
                new ObjectParameter("StartTime", typeof(System.TimeSpan));
    
            var endTimeParameter = endTime.HasValue ?
                new ObjectParameter("EndTime", endTime) :
                new ObjectParameter("EndTime", typeof(System.TimeSpan));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("Capacity", capacity) :
                new ObjectParameter("Capacity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateShowtimes", showtimeIDParameter, movieIDParameter, showDateParameter, startTimeParameter, endTimeParameter, capacityParameter);
        }
    }
}
