namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountyMAPUpdate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Counties", newName: "Countys");
            AlterColumn("dbo.Countys", "CountyName", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countys", "CountyName", c => c.String());
            RenameTable(name: "dbo.Countys", newName: "Counties");
        }
    }
}
