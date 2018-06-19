namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'04b0597b-eade-4786-a0e1-ba9b9ea9e108', N'guest@vidly.com', 0, N'AKxYojzHqPcVg/Ncb8p6ZQ58uzuwFwsFghClMa1dmavmKxndBpFla9ERNQ2ngKDyPA==', N'e1ddc221-14f6-4a76-ab4a-7012aabc31b6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'79fed6e6-9fd1-4e76-be9e-8615f78f94d8', N'admin@vidly.com', 0, N'ABY+k7feoBYaXED+dQKUNs7lEU+Cz9Cx9JPkIjAS/ncBdMlFyxI0yXbDv4pUNZK1KA==', N'bbf8902f-349a-477d-bc30-5a000fcf9806', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2864f804-358b-49e0-bc77-1941f937b2c1', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'79fed6e6-9fd1-4e76-be9e-8615f78f94d8', N'2864f804-358b-49e0-bc77-1941f937b2c1')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
