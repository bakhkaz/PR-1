﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    internal class Admin:User
    {
        public Admin(string name, string login, string password) : base(name, login, password) { }
    }
}
