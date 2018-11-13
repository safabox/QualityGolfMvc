namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingPlanDuration : DbMigration
    {
        public override void Up()
        {
            //Sql("update Planes set durationindays=60 where name = 'Pack de Prueba'");
            //Sql("update Planes set durationindays=30 where name = 'Membresia mensual 4 clases'");
            //Sql("update Planes set durationindays=30 where name = 'Membresia mensual 8 clases'");
            //Sql("update Planes set durationindays=180 where name = 'Membresia semestral 24 clases'");
            //Sql("update Planes set durationindays=180 where name = 'Membresia semestral 48 clases'");
            //Sql("update Planes set durationindays=365 where name ='Membresia anual 48 clases'");
            //Sql("update Planes set durationindays=365 where name = 'Membresia anual 96 clases'");
            //Sql("update Planes set durationindays=365 where name = 'Membresia anual 96 clases con salida'");


        }
        
        public override void Down()
        {
        }
    }
}
