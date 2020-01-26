namespace Classic_Jaguar_MVC_App.Migrations
{
    using Classic_Jaguar_MVC_App.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Classic_Jaguar_MVC_App.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Classic_Jaguar_MVC_App.Models.ApplicationDbContext context)
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
            context.JagModels.AddOrUpdate(
                j => j.ModelId,
                new car
                {
                    ModelId = 1,
                    ModelName = "XKE",
                    FirstYear = 1961,
                    LastYear = 1975,
                    UnitsProduced = 70000,
                    Description = "Description text goes here.",
                    Synopsis = "Synopsis text goes here.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/1963_Jaguar_XK-E_Roadster.jpg/2560px-1963_Jaguar_XK-E_Roadster.jpg",
                    DateCreated = DateTime.Now
                },

                new car
                {
                    ModelId = 2,
                    ModelName = "Mark 2",
                    FirstYear = 1959,
                    LastYear = 1967,
                    UnitsProduced = 91222,
                    Description = "Description text goes here.",
                    Synopsis = "Synopsis text goes here.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cd/Jaguar.3point4.750pix.jpgg",
                    DateCreated = DateTime.Now
                },
                new car
                {
                    ModelId = 3,
                    ModelName = "XK120",
                    FirstYear = 1948,
                    LastYear = 1954,
                    UnitsProduced = 12055,
                    Description = "Description text goes here.",
                    Synopsis = "Synopsis text goes here.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a8/Chichester_-_Jaguar_XK120_-_geograph.org.uk_-_1349971.jpg",
                    DateCreated = DateTime.Now
                };
            );

                context.JagModels.AddOrUpdate(
                    t => t.TransactionID,
                new transaction
    {
        ModelId = 1,
        ModelName = "XKE",
        FirstYear = 1961,
        LastYear = 1975,
        UnitsProduced = 70000,
        Description = "Description text goes here.",
        Synopsis = "Synopsis text goes here.",
        ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/1963_Jaguar_XK-E_Roadster.jpg/2560px-1963_Jaguar_XK-E_Roadster.jpg",
        DateCreated = DateTime.Now
    },

    new car
    {
        ModelId = 2,
        ModelName = "Mark 2",
        FirstYear = 1959,
        LastYear = 1967,
        UnitsProduced = 91222,
        Description = "Description text goes here.",
        Synopsis = "Synopsis text goes here.",
        ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cd/Jaguar.3point4.750pix.jpgg",
        DateCreated = DateTime.Now
    },
    new car
    {
        ModelId = 3,
        ModelName = "XK120",
        FirstYear = 1948,
        LastYear = 1954,
        UnitsProduced = 12055,
        Description = "Description text goes here.",
        Synopsis = "Synopsis text goes here.",
        ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a8/Chichester_-_Jaguar_XK120_-_geograph.org.uk_-_1349971.jpg",
        DateCreated = DateTime.Now
    }

    );
        }
    }
}