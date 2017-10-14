using System.Data.Entity;
using TrafficLightsControlV1.Web.DomainModels;

namespace TrafficLightsControlV1.Web.DbContexts
{
    public class TrafficLightsControlV1DbContext : DbContext
    {
        public TrafficLightsControlV1DbContext() : base("TrafficLightsControlV1Connection")
        {
        }
        public DbSet<SystemWideSetting> SystemWideSettings { get; set; }
    }
}