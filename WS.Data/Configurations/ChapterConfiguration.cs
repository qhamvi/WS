using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Data.Entities;

namespace WS.Data.Configurations
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            //Ten bang genarate at SQL
            builder.ToTable("Chapters");
            builder.HasKey(x => x.IdChapter);
            builder.Property(x => x.CreateDate).IsRequired(true);
            //1 Chapter thuoc 1 Story
            //1 Story co nhieu Chapter
            builder.HasOne(x => x.Story).WithMany(x => x.Chapters).HasForeignKey(x => x.IdStory);
            builder.Property(x => x.Collector).IsRequired(true);
            builder.Property(x => x.Content).IsRequired(true).HasMaxLength(1000);
            builder.Property(x => x.TitleChap).IsRequired(true);

        }
    }
}
