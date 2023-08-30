﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using UserManagement.Models;

namespace UserManagement.Data
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
