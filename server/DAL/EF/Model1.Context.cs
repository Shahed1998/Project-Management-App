﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Project_ManagementEntities : DbContext
    {
        public Project_ManagementEntities()
            : base("name=Project_ManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Project_Members> Project_Members { get; set; }
        public DbSet<Project_Status> Project_Status { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User_Roles> User_Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}