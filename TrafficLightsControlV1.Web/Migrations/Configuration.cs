namespace TrafficLightsControlV1.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrafficLightsControlV1.Web.DbContexts.TrafficLightsControlV1DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrafficLightsControlV1.Web.DbContexts.TrafficLightsControlV1DbContext context)
        {
            if(context.SystemWideSettings.Count() <= 0)
            {
                context.SystemWideSettings.Add(new DomainModels.SystemWideSetting
                {
                    IsActive = false,
                    Signal1Time = 5,
                    Signal2Time = 5,
                    Signal3Time = 5,
                    Signal4Time = 5
                });
                context.SaveChanges();
            }

            if(context.TrafficJunctions.Count() <= 0)
            {
                context.TrafficJunctions.Add(new DomainModels.TrafficJunction { Name = "Demo Junction" });
                context.SaveChanges();
            }

            if(context.TrafficSignals.Count() <= 0)
            {
                var firstJunction = context.TrafficJunctions.FirstOrDefault();
                context.TrafficSignals.Add(new DomainModels.TrafficSignal
                {
                    ExitDirection = Enums.ExitDirection.EXITUP,
                    IsGreen = false,
                    TrafficJunction_Id = firstJunction.Id,
                    SignalTime = 2
                });
                context.TrafficSignals.Add(new DomainModels.TrafficSignal
                {
                    ExitDirection = Enums.ExitDirection.EXITRIGHT,
                    IsGreen = false,
                    TrafficJunction_Id = firstJunction.Id,
                    SignalTime = 2
                });
                context.TrafficSignals.Add(new DomainModels.TrafficSignal
                {
                    ExitDirection = Enums.ExitDirection.EXITDOWN,
                    IsGreen = false,
                    TrafficJunction_Id = firstJunction.Id,
                    SignalTime = 2
                });
                context.TrafficSignals.Add(new DomainModels.TrafficSignal
                {
                    ExitDirection = Enums.ExitDirection.EXITLEFT,
                    IsGreen = false,
                    TrafficJunction_Id = firstJunction.Id,
                    SignalTime = 2
                });
                context.SaveChanges();
            }
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
        }
    }
}
