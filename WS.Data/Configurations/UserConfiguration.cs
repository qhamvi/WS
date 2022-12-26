using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Data.Entities;

namespace WS.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.FullName).IsRequired(true);
            builder.Property(x => x.Country).IsRequired(true);
            builder.Property(x => x.CreateDate).IsRequired(true);   
        }
    }
}
