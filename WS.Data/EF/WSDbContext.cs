using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Data.Configurations;
using WS.Data.Entities;

namespace WS.Data.EF
{
    public class WSDbContext : DbContext
    {
        public WSDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Topic> Topics { get; set; }    
        public DbSet<Comment> Chapters { get;set; }

        //public DbSet<Role> Roles { get; set; }
        public DbSet<Story> Stories { get; set; }

        // Specify DbSet properties etc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add your own configuration here
            modelBuilder.ApplyConfiguration(new ChapterConfiguration());

        }

    }
}
