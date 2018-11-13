namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDurationToPlan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plan", "DurationInDays", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plan", "DurationInDays");
        }
    }
}
