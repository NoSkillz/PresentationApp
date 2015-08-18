namespace PresentationApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PresentationApp.Models.PresentationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PresentationApp.Models.PresentationContext";
        }

        protected override void Seed(PresentationApp.Models.PresentationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Presentations.AddOrUpdate(
                p => p.Id,
                new Presentation
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Desc",
                    Date = DateTime.Now,
                    someNumber = 1
                });
        }
    }
}
