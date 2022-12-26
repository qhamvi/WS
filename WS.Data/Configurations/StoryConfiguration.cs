using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Data.Entities;

namespace WS.Data.Configurations
{
    public class StoryConfiguration : IEntityTypeConfiguration<Story>
    {
        public void Configure(EntityTypeBuilder<Story> builder)
        {
            builder.ToTable("Stories");
            builder.HasKey(x => x.IdStory);
            builder.Property(x => x.Author).IsRequired(true);
            builder.Property(x => x.Collector).IsRequired(true);
            builder.Property(x => x.IsComplete).IsRequired(true);
            builder.Property(x => x.CreateDate).IsRequired(true);
            builder.Property(x => x.ImageFileName).IsRequired(true);
            builder.Property(x => x.Summary).IsRequired(true);

        }
    }
}
