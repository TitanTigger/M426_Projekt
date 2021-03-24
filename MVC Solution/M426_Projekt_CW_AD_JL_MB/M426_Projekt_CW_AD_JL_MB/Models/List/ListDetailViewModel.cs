using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M426_Projekt_CW_AD_JL_MB.Data;
using M426_Projekt_CW_AD_JL_MB.Models.Priority;
using M426_Projekt_CW_AD_JL_MB.Models.Status;
using M426_Projekt_CW_AD_JL_MB.Models.Task;
using Microsoft.AspNetCore.Identity;

namespace M426_Projekt_CW_AD_JL_MB.Models.List
{
    public class ListDetailViewModel
    {
        // View Model für Detail-Ansicht
        public int ListId { get; set; }
        public List<TaskModel> Tasks { get; set; }
        public List<StatusModel> Status { get; set; }
        public List<PriorityModel> Priority { get; set; }
        public List<IdentityUser> Users { get; set; }
    }
}
