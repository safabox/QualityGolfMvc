namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePriceToPlanes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planes", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planes", "Price");
        }
    }
}
