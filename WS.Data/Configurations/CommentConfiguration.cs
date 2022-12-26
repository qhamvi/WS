using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Data.Entities;

namespace WS.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.IdComment);
            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.Story).WithMany(x => x.Comments).HasForeignKey(x => x.IdStory);
            builder.Property(x => x.Content).IsRequired(true);
            builder.Property(x => x.DateCom).IsRequired(true);

        }
    }
}
