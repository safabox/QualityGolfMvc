namespace qualityBackup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingUsersAndRoles : DbMigration
    {
        public override void Up()
        {

            Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'35cfe721-af56-4b9d-bd7b-59790d09e251', N'Administrator')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'819daf3f-a391-4983-b4eb-0b9ebc491371', N'Alumno')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0c38cc5e-610e-4e81-b826-7ca18e9aa0a7', N'Profesor')

                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'016a2f11-8dfc-4342-be63-7092b52f114a', N'admin@quality.com', 0, N'ALiDoGewbwKzIRmtmN0u8Nuk38WTC+Cg5dthrFSO/cnwR4Jh1ocyG9Qu32tDxFp55A==', N'c79c498d-e356-4781-9ee9-592c7ea6fc66', NULL, 0, 0, NULL, 1, 0, N'admin@quality.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'86aed824-1216-4ba4-9c08-7c59185afb0f', N'alumno@quality.com', 0, N'AEG4dSiXTlPm7VUWcrKBzH2n4b0Qt84eAjl76RgxaRYNh53CGXniPPCZlPBpD0FDsg==', N'2fb7f47f-8c0f-4649-8181-f1b8290b1423', NULL, 0, 0, NULL, 1, 0, N'alumno@quality.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'910c434c-d24c-45f6-b7d2-d7ed847408b2', N'profesor@quality.com', 0, N'AJYTayxfN769Bx2SkjIvF5jsYvEwDKM2ZUH9DPE4A3nubH+t6caVqzMcFA1bUW/JYQ==', N'dfe18cba-eac0-469a-949d-a835828e0771', NULL, 0, 0, NULL, 1, 0, N'profesor@quality.com')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'910c434c-d24c-45f6-b7d2-d7ed847408b2', N'0c38cc5e-610e-4e81-b826-7ca18e9aa0a7')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'016a2f11-8dfc-4342-be63-7092b52f114a', N'35cfe721-af56-4b9d-bd7b-59790d09e251')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'86aed824-1216-4ba4-9c08-7c59185afb0f', N'819daf3f-a391-4983-b4eb-0b9ebc491371')


            ");

        }
        
        public override void Down()
        {
        }
    }
}
