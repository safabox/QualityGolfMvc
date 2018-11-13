namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePlanInformation : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Planes (name,description,planTypeId,AmountOfClasses,AmountOfClassesPerMonth,active,durationindays) values ('Pack de Prueba','Pack de Prueba',1,10,5,1,60)");
            Sql("Insert into Planes (name,description,planTypeId,AmountOfClasses,AmountOfClassesPerMonth,active,durationindays) values ('Membresia mensual 4 clases','Membresia mensual 4 clases',(select id from plantype where name='Plan'),4,4,1,30)");
            Sql("Insert into Planes (name,description,planTypeId,AmountOfClasses,AmountOfClassesPerMonth,active,durationindays) values ('Membresia mensual 8 clases','Membresia mensual 8 clases',(select id from plantype where name='Plan'),8,8,1,30)");
            Sql("Insert into Planes (name,description,planTypeId,AmountOfClasses,AmountOfClassesPerMonth,active,durationindays) values ('Membresia semestral 24 clases','Membresia semestral 24 clases',(select id from plantype where name='Plan'),24,4,1,180)");
            Sql("Insert into Planes (name,description,planTypeId,AmountOfClasses,AmountOfClassesPerMonth,active,durationindays) values ('Membresia semestral 48 clases','Membresia semestral 48 clases',(select id from plantype where name='Plan'),48,8,1,180)");
            Sql("Insert into Planes (name,description,planTypeId,AmountOfClasses,AmountOfClassesPerMonth,active,durationindays) values ('Membresia anual 48 clases','Membresia anual 48 clases',(select id from plantype where name='Plan'),48,4,1,365)");
            Sql("Insert into Planes (name,description,planTypeId,AmountOfClasses,AmountOfClassesPerMonth,active,durationindays) values ('Membresia anual 96 clases','Membresia anual 96 clases',(select id from plantype where name='Plan'),96,8,1,365)");
            Sql("Insert into Planes (name,description,planTypeId,AmountOfClasses,AmountOfClassesPerMonth,active,durationindays) values ('Membresia anual 96 clases con salida','Membresia anual 96 clases con salidas a la cancha',(select id from plantype where name='Curso'),96,8,1,365)");
        }

        public override void Down()
        {
        }
    }
}
