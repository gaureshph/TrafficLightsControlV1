namespace TrafficLightsControlV1.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSignalTimeToEachSignal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrafficSignals", "SignalTime", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrafficSignals", "SignalTime");
        }
    }
}
