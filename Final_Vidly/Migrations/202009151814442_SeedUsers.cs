namespace Final_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4a5518a8-a664-4cb9-a736-f209805c65fb', N'guest@vidly.com', 0, N'AG5k8KYgH2koyx8dafsWkJKJW0W2HzjAIsjPA6LPjzM6J9Zv4EOd9v7yhF+1j/pr9A==', N'a877bc76-eb79-4730-9779-c4acf35d67d5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fa2a0a22-7945-44c4-afd5-0067078195ce', N'admin@vidly.com', 0, N'AIATKbEYttce1LFlkjSejTaxZHOqNPJC58ArfJikhnLhEl4jtB8vgLgR+xDyQjzVOg==', N'9499c9ee-4b6d-4bbb-b1ff-aacfe1df0ee3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'be3ff3d8-97da-42d3-aba4-b0f143235f48', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fa2a0a22-7945-44c4-afd5-0067078195ce', N'be3ff3d8-97da-42d3-aba4-b0f143235f48')

");
        }
        
        public override void Down()
        {
        }
    }
}
