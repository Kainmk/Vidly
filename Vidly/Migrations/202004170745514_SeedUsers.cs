namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1e0e9b4b-847f-4356-b0f4-b3538cd9d727', N'guest@vidly.com', 0, N'AJdzxL/r3dCHus6vx6A5ew6YmZGuirwC/PvRLV06fzx2rr79dFCdYHyYXLBBZG9DNw==', N'2e749df3-cd58-4477-b216-191f09f1ed74', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9a13c9e2-7f0c-498c-bed4-21b033cce448', N'admin@vidly.com', 0, N'ADUBPSrcFrfT7NXofhtRlRmgoMbWlCedVUCAa0JQAzdgZ8rzQ9J9F9s+CR+I/atLEg==', N'f0f02c79-dcea-4aae-b924-863f1d27b565', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'33936902-3fa8-4cad-9295-c9683d026561', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9a13c9e2-7f0c-498c-bed4-21b033cce448', N'33936902-3fa8-4cad-9295-c9683d026561')
");
        }
        
        public override void Down()
        {
        }
    }
}
