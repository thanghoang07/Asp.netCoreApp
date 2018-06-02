using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Data.Entities;
using static WebApp.Data.EF.Extensions.ModelbuilderExtensions;

namespace WebApp.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
        }
    }
}
