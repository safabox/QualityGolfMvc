namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingEnrollmentEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(maxLength: 128),
                        ClaseId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Asistencia = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clase", t => t.ClaseId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId)
                .Index(t => t.ClaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Enrollment", "ClaseId", "dbo.Clase");
            DropIndex("dbo.Enrollment", new[] { "ClaseId" });
            DropIndex("dbo.Enrollment", new[] { "ApplicationUserId" });
            DropTable("dbo.Enrollment");
        }
    }
}
