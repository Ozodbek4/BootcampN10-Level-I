﻿using N24HomeTask1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24HomeTask1.Services
{
    internal class UserCredentials
    {
        public UserCredentials(int id, string password, int userId)
        {
            Id = id;
            Password = password;
            UserId = userId;
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
    }
}
