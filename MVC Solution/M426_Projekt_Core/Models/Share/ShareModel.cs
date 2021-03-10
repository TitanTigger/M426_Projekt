﻿using M426_Project.Models.List;
using M426_Project.Models.Role;
using M426_Project.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M426_Projekt_Core.Models.Share
{
    public class ShareModel
    {
        public int Id { get; set; }
        public virtual UserModel User { get; set; }
        public virtual ListModel List { get; set; }
        public virtual RoleModel Role { get; set; }
        
    }
}
