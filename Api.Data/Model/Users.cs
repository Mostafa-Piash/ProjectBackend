﻿using System;
using System.Collections.Generic;
using System.Text;

namespace API.Data.Model
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
        public string Address { get; set; }
    }
}
