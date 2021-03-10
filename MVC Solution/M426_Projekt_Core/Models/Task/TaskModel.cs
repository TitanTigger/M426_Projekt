using M426_Projekt_Core.Models.Priority;
using M426_Projekt_Core.Models.Status;
using M426_Projekt_Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M426_Projekt_Core.Models.Task
{
    public class TaskModel
    {
        public int Id { get; set; }
        public virtual StatusModel Status { get; set; }
        public virtual UserModel User { get; set; }
        public virtual PriorityModel Priority { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
