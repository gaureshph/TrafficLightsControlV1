namespace TrafficLightsControlV1.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedJunctionsAndSignals2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrafficJunctions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrafficSignals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrafficJunction_Id = c.Int(nullable: false),
                        ExitDirection = c.Int(nullable: false),
                        IsGreen = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TrafficJunctions", t => t.TrafficJunction_Id, cascadeDelete: true)
                .Index(t => t.TrafficJunction_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrafficSignals", "TrafficJunction_Id", "dbo.TrafficJunctions");
            DropIndex("dbo.TrafficSignals", new[] { "TrafficJunction_Id" });
            DropTable("dbo.TrafficSignals");
            DropTable("dbo.TrafficJunctions");
        }
    }
}
