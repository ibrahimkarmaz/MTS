namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewNoteColumnName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "NoteStopDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notes", "NoteStopDate");
        }
    }
}
