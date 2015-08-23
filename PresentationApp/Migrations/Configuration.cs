namespace PresentationApp.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PresentationApp.Models.PresentationDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "PresentationApp.Models.PresentationDb";
        }

        protected override void Seed(PresentationDb context)
        {
            // Seed the presentations first
            context.Presentations.AddOrUpdate(
                p => p.Id,
                new Presentation
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Desc",
                    Date = DateTime.Now,
                });

            // Then seed some examples and FK to them using PresentationId
            context.Examples.AddOrUpdate(
                p => p.Id,
                new DataTypesExample
                {
                    Id = 1,
                    FirstChar = 'a',
                    SecondChar = null,
                    FirstDouble = null,
                    SecondDouble = null,
                    FirstFloat = null,
                    SecondFloat = null,
                    FirstInteger = null,
                    SecondInteger = null,
                    PresentationId = 1
                },
                new DataTypesExample
                {
                    Id = 2,
                    FirstChar = null,
                    SecondChar = null,
                    FirstDouble = null,
                    SecondDouble = null,
                    FirstFloat = null,
                    SecondFloat = null,
                    FirstInteger = null,
                    SecondInteger = null,
                    PresentationId = 1
                });
        }

    }
}
