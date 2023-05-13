namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupportPeriodMAPUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SupportPeriods", "SupportPeriodProgress", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.SupportPeriods", "SupportPeriodProgressDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SupportPeriods", "SupportPeriodProgressDate", c => c.DateTime());
            AlterColumn("dbo.SupportPeriods", "SupportPeriodProgress", c => c.String());
        }
    }
}
