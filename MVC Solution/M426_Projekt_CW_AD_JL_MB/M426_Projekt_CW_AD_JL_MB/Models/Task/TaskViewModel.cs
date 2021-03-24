using System;
using M426_Projekt_CW_AD_JL_MB.Models.Priority;
using M426_Projekt_CW_AD_JL_MB.Models.Status;
using Microsoft.AspNetCore.Identity;

namespace M426_Projekt_CW_AD_JL_MB.Models.Task
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public int StatusId { get; set; }
        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }
        public int PriorityId { get; set; }
        public virtual StatusModel Status { get; set; }
        public virtual PriorityModel Priority { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
