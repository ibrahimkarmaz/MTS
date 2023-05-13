namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumnType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Counties", "CountyName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Counties", "CountyName", c => c.Int(nullable: false));
        }
    }
}
