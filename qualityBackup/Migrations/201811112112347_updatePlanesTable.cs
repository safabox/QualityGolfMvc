namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePlanesTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Plan", newName: "Planes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Planes", newName: "Plan");
        }
    }
}
