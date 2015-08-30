namespace PresentationApp.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PresentationApp.Models.PresentationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "PresentationApp.Models.PresentationDb";
        }

        protected override void Seed(PresentationDbContext context)
        {
            // Seed the presentations first
            context.Presentations.AddOrUpdate(
                p => p.Id,
                new Presentation
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Desc",
                    Date = DateTime.Now.Date
                },
                new Presentation
                {
                    Id = 2,
                    Name = "Second Presentation",
                    Description = "The description for the second presentation",
                    Date = DateTime.Now.Date
                }
                );

            // Then seed some examples and FK to them using PresentationId
            context.Examples.AddOrUpdate(
                p => p.Id,
                // Examples for the first presentation
                new DataTypes
                {
                    Id = 1,
                    FirstDouble = null,
                    SecondDouble = null,
                    FirstFloat = null,
                    SecondFloat = null,
                    FirstInteger = null,
                    SecondInteger = null,
                    PresentationId = 1
                },
                new DataTypes
                {
                    Id = 2,
                    FirstDouble = null,
                    SecondDouble = null,
                    FirstFloat = null,
                    SecondFloat = null,
                    FirstInteger = null,
                    SecondInteger = null,
                    PresentationId = 1
                },
                //Examples for the second presentation
                new DataTypes
                {
                    Id = 3,
                    FirstDouble = null,
                    SecondDouble = null,
                    FirstFloat = null,
                    SecondFloat = null,
                    FirstInteger = null,
                    SecondInteger = null,
                    PresentationId = 2
                });
        }

    }
}
