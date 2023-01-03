using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WS.Data.Entities;

namespace WS.Data.Configurations
{
    public class UserLikeStoryConfiguration : IEntityTypeConfiguration<UserLikeStory>
    {
        public void Configure(EntityTypeBuilder<UserLikeStory> builder)
        {
            builder.HasKey(t => new { t.IdUser, t.IdStory});

            builder.ToTable("UserLikeStories");

            builder.HasOne(t => t.Story).WithMany(pc => pc.UserLikeStories)
                .HasForeignKey(pc => pc.IdStory);

            builder.HasOne(t => t.User).WithMany(pc => pc.UserLikeStories)
              .HasForeignKey(pc => pc.IdUser);
        }
    }
}