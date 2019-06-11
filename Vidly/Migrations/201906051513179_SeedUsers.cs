namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3d97b9f4-8fa4-40a0-9ccf-ae471008cffb', N'guest@vidly.com', 0, N'AKRedt/0a40G9eDabfGQWRnXYrlzW4/CrBx8Y9Dy9Cg5sb/uuBcjTwq7e5AJKX9QoA==', N'c9275113-71f6-49f9-877f-ab9b7d1a153d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a679002f-0cbe-49a8-8ed3-4e4d47b78a84', N'admin@vidly.com', 0, N'AMAKdHjObex5FR539dSYYVZF0Zpn6tQDOPVKajZVHn8AjJg1R3/FaGTeKSxu5ue/3g==', N'4b57902d-7b19-47ed-b652-a2563625628f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9f8d7d61-7137-43da-aee5-ecc1cdcf0322', N'CanManageMovies')
                INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a679002f-0cbe-49a8-8ed3-4e4d47b78a84', N'9f8d7d61-7137-43da-aee5-ecc1cdcf0322')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
