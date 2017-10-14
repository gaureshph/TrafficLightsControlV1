namespace TrafficLightsControlV1.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialConfig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemWideSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        Signal1Time = c.Int(nullable: false),
                        Signal2Time = c.Int(nullable: false),
                        Signal3Time = c.Int(nullable: false),
                        Signal4Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemWideSettings");
        }
    }
}
