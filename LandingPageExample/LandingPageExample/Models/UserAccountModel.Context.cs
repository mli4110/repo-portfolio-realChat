﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandingPageExample.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UserAccountDBEntities : DbContext
    {
        public UserAccountDBEntities()
            : base("name=UserAccountDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Activity> User_Activity { get; set; }
    }
}
