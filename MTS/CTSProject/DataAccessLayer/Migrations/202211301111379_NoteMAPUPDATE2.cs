namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoteMAPUPDATE2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notes", "NoteTitle", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Notes", "NoteContent", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Notes", "NoteStopDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notes", "NoteStopDate", c => c.DateTime());
            AlterColumn("dbo.Notes", "NoteContent", c => c.String());
            AlterColumn("dbo.Notes", "NoteTitle", c => c.String());
        }
    }
}
