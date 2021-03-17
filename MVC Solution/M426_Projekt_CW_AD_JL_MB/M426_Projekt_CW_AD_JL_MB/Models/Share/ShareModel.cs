using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using M426_Projekt_CW_AD_JL_MB.Models.List;
using M426_Projekt_CW_AD_JL_MB.Models.Role;
using M426_Projekt_CW_AD_JL_MB.Models.User;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace M426_Projekt_CW_AD_JL_MB.Models.Share
{
    public class ShareModel
    {
        public int Id { get; set; }
        public virtual IdentityUser User { get; set; }

        public int ListId { get; set; }

        public string UserId { get; set; }

        //[ForeignKey("ListId")]
        public virtual ListModel List { get; set; }
        public virtual RoleModel Role { get; set; }
        
    }
}
