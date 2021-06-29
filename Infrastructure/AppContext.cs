using BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTracker.Infrastructure
{
    public class AppContext:DbContext
    {

        public AppContext(DbContextOptions options)
            : base(options) { }
        public DbSet<User> Users { get; set; }

        
    }
}
