namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class includeDatesAndAmountOnSubscripcion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscripcion", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subscripcion", "EndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subscripcion", "AmountOfClasses", c => c.Int(nullable: false));
            AddColumn("dbo.Subscripcion", "AmountClasessPerMonth", c => c.Int(nullable: false));
            AddColumn("dbo.Subscripcion", "PendingAmountOfClasses", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscripcion", "PendingAmountOfClasses");
            DropColumn("dbo.Subscripcion", "AmountClasessPerMonth");
            DropColumn("dbo.Subscripcion", "AmountOfClasses");
            DropColumn("dbo.Subscripcion", "EndDate");
            DropColumn("dbo.Subscripcion", "StartDate");
        }
    }
}
