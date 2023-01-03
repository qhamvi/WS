using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WS.Data.Entities;

namespace WS.Data.Configurations
{
    public class UserHistoryChapterConfiguration : IEntityTypeConfiguration<UserHistoryChapter>
    {
        public void Configure(EntityTypeBuilder<UserHistoryChapter> builder)
        {
            builder.HasKey(t => new { t.IdUser, t.IdChapter });

            builder.ToTable("UserHistoryChapters");

            builder.HasOne(t => t.Chapter).WithMany(pc => pc.UserHistoryChapters)
                .HasForeignKey(pc => pc.IdChapter);

            builder.HasOne(t => t.User).WithMany(pc => pc.UserHistoryChapters)
              .HasForeignKey(pc => pc.IdUser);
        }
    }
}