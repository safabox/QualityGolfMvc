namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlanConfiguration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        PlanTypeId = c.Int(nullable: false),
                        AmountOfClasses = c.Int(nullable: false),
                        AmountofClassesPerMonth = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subscripcion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(nullable: false),
                        PlanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plan", t => t.PlanId, cascadeDelete: true)
                .Index(t => t.PlanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subscripcion", "PlanId", "dbo.Plan");
            DropIndex("dbo.Subscripcion", new[] { "PlanId" });
            DropTable("dbo.Subscripcion");
            DropTable("dbo.PlanType");
            DropTable("dbo.Plan");
        }
    }
}
