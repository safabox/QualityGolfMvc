namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingClasesEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clase", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Clase", new[] { "ApplicationUserId" });
            DropTable("dbo.Clase");
        }
    }
}
