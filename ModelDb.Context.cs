﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelDb : DbContext
    {
        public ModelDb()
            : base("name=ModelDb")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<AvailableCourses> AvailableCourses { get; set; }
        public virtual DbSet<Billings> Billings { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Enrollments> Enrollments { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<SchoolYears> SchoolYears { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<Semesters> Semesters { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserRolesInActions> UserRolesInActions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<EnrolledSubject> EnrolledSubject { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<AvailableMiscellaneous> AvailableMiscellaneous { get; set; }
        public virtual DbSet<Miscellaneous> Miscellaneous { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Announcements> Announcements { get; set; }
        public virtual DbSet<AvailableSubjects> AvailableSubjects { get; set; }
        public virtual DbSet<Schedules> Schedules { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
    }
}
