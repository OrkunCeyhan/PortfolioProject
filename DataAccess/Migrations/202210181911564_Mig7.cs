namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 30),
                        Job = c.String(maxLength: 40),
                        Description = c.String(maxLength: 150),
                        CvLink = c.String(maxLength: 150),
                        Mail = c.String(maxLength: 75),
                        MobilePhone = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminName = c.String(maxLength: 50),
                        AdminPassword = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        SenderName = c.String(maxLength: 40),
                        SenderMail = c.String(maxLength: 75),
                        SenderMessage = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(maxLength: 50),
                        ProjectImgUrl = c.String(maxLength: 150),
                        ProjectDescription = c.String(maxLength: 150),
                        IsActive = c.Boolean(nullable: false),
                        ProjectLinkUrl = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceID);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        SkillName = c.String(maxLength: 50),
                        SkillPercent = c.Byte(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
            DropTable("dbo.Services");
            DropTable("dbo.Projects");
            DropTable("dbo.Contacts");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
        }
    }
}
