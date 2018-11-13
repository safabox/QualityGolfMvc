namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingPlanType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into PlanType (name) values ('Plan')");
            Sql("Insert into PlanType (name) values ('Curso')");
            
        }
        
        public override void Down()
        {
        }
    }
}
