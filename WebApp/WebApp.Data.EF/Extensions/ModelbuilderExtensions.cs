using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.EF.Extensions
{
    public static class ModelbuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelbuilder, DbEntityConfiguration<TEntity> entityConfiguration) where TEntity : class
        {
            modelbuilder.Entity<TEntity>(entityConfiguration.Configure);
        }
        public abstract class DbEntityConfiguration<TEntity> where TEntity : class
        {
            public abstract void Configure(EntityTypeBuilder<TEntity> entity);
        }
    }
}
