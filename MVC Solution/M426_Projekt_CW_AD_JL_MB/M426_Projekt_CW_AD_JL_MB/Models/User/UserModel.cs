﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M426_Projekt_CW_AD_JL_MB.Models.User
{
    public class User
    {
        // User-Model für die Identität der Users
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
    }
}
