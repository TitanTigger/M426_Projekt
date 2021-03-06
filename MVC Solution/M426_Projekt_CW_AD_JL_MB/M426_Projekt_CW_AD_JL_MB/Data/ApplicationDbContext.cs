﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using M426_Projekt_CW_AD_JL_MB.Models.List;
using M426_Projekt_CW_AD_JL_MB.Models.Priority;
using M426_Projekt_CW_AD_JL_MB.Models.Role;
using M426_Projekt_CW_AD_JL_MB.Models.Share;
using M426_Projekt_CW_AD_JL_MB.Models.Status;
using M426_Projekt_CW_AD_JL_MB.Models.Task;
using M426_Projekt_CW_AD_JL_MB.Models.User;

namespace M426_Projekt_CW_AD_JL_MB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Entities
        public DbSet<ListModel> List { get; set; }
        public DbSet<PriorityModel> Priority { get; set; }
        //public DbSet<RoleModel> Role { get; set; }
        public DbSet<ShareModel> Share { get; set; }
        public DbSet<StatusModel> Status { get; set; }
        public DbSet<TaskModel> Task { get; set; }
        //public DbSet<UserModel> User { get; set; }
    }
}
