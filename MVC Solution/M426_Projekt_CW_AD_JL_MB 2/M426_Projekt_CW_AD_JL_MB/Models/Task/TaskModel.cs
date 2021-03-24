using M426_Projekt_CW_AD_JL_MB.Models.Priority;
using M426_Projekt_CW_AD_JL_MB.Models.Status;
using M426_Projekt_CW_AD_JL_MB.Models.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M426_Projekt_CW_AD_JL_MB.Models.Task
{
    public class TaskModel
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

        public int ChangeStatus(int id, bool back, int statusId)
        {
            if (statusId == 1)
            {
                if (back)
                {
                    return 0;
                }
                else
                {
                    statusId += 1;
                }
                // Man kann kein 'Back'
            }
            else if (statusId == 3)
            {
                if (!back)
                {
                    return 0;
                }
                else
                {
                    statusId -= 1;
                }
                // Man kann nicht 'Weiter'
            }
            else
            {
                if (back)
                {
                    statusId -= 1;
                }
                else
                {
                    statusId += 1;
                }
                //Status in jede Richtung
            }
            return statusId;
        }
    }
}
