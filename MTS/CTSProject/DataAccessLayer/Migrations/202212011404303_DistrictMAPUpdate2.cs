namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DistrictMAPUpdate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Districts", "DistrictName", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Districts", "DistrictName", c => c.String());
        }
    }
}
