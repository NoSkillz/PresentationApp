﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PresentationApp.Models
{
    public class PresentationDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PresentationDbContext() : base("name=Default")
        {
        }

        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<DataTypes> Examples { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataTypes>().Property(d => d.Decimal).HasPrecision(18, 10);
            base.OnModelCreating(modelBuilder);
        }
    }
}
