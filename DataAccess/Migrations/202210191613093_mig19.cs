namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig19 : DbMigration
    {
        public override void Up()
        {
            //tüm tablolardaki description kolonların lengti 500 olarak güncellendi.
            AddColumn("dbo.Services", "ServiceDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.Abouts", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Contacts", "SenderMessage", c => c.String(maxLength: 500));
            AlterColumn("dbo.Projects", "ProjectDescription", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "ProjectDescription", c => c.String(maxLength: 150));
            AlterColumn("dbo.Contacts", "SenderMessage", c => c.String(maxLength: 250));
            AlterColumn("dbo.Abouts", "Description", c => c.String(maxLength: 150));
            DropColumn("dbo.Services", "ServiceDescription");
        }
    }
}
