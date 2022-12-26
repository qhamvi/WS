using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Data.Configurations;
using WS.Data.Entities;
using WS.Data.Extensions;

namespace WS.Data.EF
{
    public class WSDbContext : IdentityDbContext<User, Role, Guid>
    {
        public WSDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Topic> Topics { get; set; }    
        public DbSet<Comment> Chapters { get;set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public override DbSet<User> Users { get; set; }
        public override DbSet<Role> Roles { get; set; }


        // Specify DbSet properties etc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure Fluent API
            base.OnModelCreating(modelBuilder);
            // add your own configuration here
            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new ChapterConfiguration());
            modelBuilder.ApplyConfiguration(new StoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");

            //DataSeeding
            // modelBuilder.Entity<Topic>().HasData(
            //     new Topic() {
            //         IdTopic = Guid.NewGuid().ToString(), 
            //         NameTopic = "Tiên hiệp"
            //     },
            //     new Topic() {
            //         IdTopic = Guid.NewGuid().ToString(), 
            //         NameTopic = "Kiếm hiệp"
            //     },
            //     new Topic() {
            //         IdTopic = Guid.NewGuid().ToString(), 
            //         NameTopic = "Ngôn tình"
            //     });
            modelBuilder.Seed();

        }

    }
}
