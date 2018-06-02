using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;
using static WebApp.Data.EF.Extensions.ModelbuilderExtensions;

namespace WebApp.Data.EF.Configurations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
