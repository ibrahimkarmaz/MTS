namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntityCounty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        CountyID = c.Int(nullable: false, identity: true),
                        CountyName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CountyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Counties");
        }
    }
}
