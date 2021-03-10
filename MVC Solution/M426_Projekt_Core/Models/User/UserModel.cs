using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M426_Projekt_Core.Models.User
{
    public class UserModel
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set }
        public string nickname { get; set; }
    }
}
