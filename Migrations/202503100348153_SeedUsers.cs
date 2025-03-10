namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a5a8cfdb-c32c-4f85-960d-1cb6bd241260', N'123456', N'0122497882', N'admin@vidly.com', 0, N'AMZsWnLwThzIT8uBiy6iQhO4hcf04JSshRnLM8/gWfRcwAcjbszbHuaQdsXrbbBKcA==', N'c7702ad1-e67c-45f0-8945-7523d655a5dd', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'042019dc-4e8c-4672-91f3-2d315dea9475', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a5a8cfdb-c32c-4f85-960d-1cb6bd241260', N'042019dc-4e8c-4672-91f3-2d315dea9475')

"
);
        }
        
        public override void Down()
        {
        }
    }
}
