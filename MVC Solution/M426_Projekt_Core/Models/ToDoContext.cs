using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M426_Projekt_Core.Models.List;
using M426_Projekt_Core.Models.Priority;
using M426_Projekt_Core.Models.Role;
using M426_Projekt_Core.Models.Share;
using M426_Projekt_Core.Models.Status;
using M426_Projekt_Core.Models.Task;
using M426_Projekt_Core.Models.User;
using Microsoft.AspNetCore.Identity;

namespace M426_Projekt_Core.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //Entities
        public DbSet<ListModel> List { get; set; }
        public DbSet<PriorityModel> Priority { get; set; }
        public DbSet<RoleModel> Role { get; set; }
        public DbSet<ShareModel> Share { get; set; }
        public DbSet<StatusModel> Status { get; set; }
        public DbSet<TaskModel> Task { get; set; }
        public DbSet<UserModel> User { get; set; }
    }
}
