namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupportMAPUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Supports", "SupportTitle", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Supports", "SupportContent", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Supports", "SupportOpenDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Supports", "SupportCloseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Supports", "SupportCloseDate", c => c.DateTime());
            AlterColumn("dbo.Supports", "SupportOpenDate", c => c.DateTime());
            AlterColumn("dbo.Supports", "SupportContent", c => c.String());
            AlterColumn("dbo.Supports", "SupportTitle", c => c.String());
        }
    }
}
