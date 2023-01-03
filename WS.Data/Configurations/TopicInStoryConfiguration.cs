using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Data.Entities;

namespace WS.Data.Configurations
{
    public class TopicInStoryConfiguration : IEntityTypeConfiguration<TopicInStory>
    {
        public void Configure(EntityTypeBuilder<TopicInStory> builder)
        {
            builder.HasKey(t => new { t.IdStory, t.IdTopic});

            builder.ToTable("TopicInStory");

            builder.HasOne(t => t.Story).WithMany(pc => pc.ListTopicInStory)
                .HasForeignKey(pc => pc.IdStory);

            builder.HasOne(t => t.Topic).WithMany(pc => pc.ListTopicInStory)
              .HasForeignKey(pc => pc.IdTopic);
        }
    }
    
}
