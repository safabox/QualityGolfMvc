namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingPriceToPlanes : DbMigration
    {
        public override void Up()
        {
            Sql("update Planes set price=4250 where name = 'Pack de Prueba'");
            Sql("update Planes set price=4000 where name = 'Membresia mensual 4 clases'");
            Sql("update Planes set price=6400 where name = 'Membresia mensual 8 clases'");
            Sql("update Planes set price=3200 where name = 'Membresia semestral 24 clases'");
            Sql("update Planes set price=5120 where name = 'Membresia semestral 48 clases'");
            Sql("update Planes set price=2560 where name ='Membresia anual 48 clases'");
            Sql("update Planes set price=4160 where name = 'Membresia anual 96 clases'");
            Sql("update Planes set price=5120 where name = 'Membresia anual 96 clases con salida'");
        }

        public override void Down()
        {
        }
    }
}
