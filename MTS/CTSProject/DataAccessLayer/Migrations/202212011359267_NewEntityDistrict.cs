namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntityDistrict : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictID = c.Int(nullable: false, identity: true),
                        DistrictName = c.String(),
                        CountyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DistrictID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Districts");
        }
    }
}
