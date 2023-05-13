namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        TCNO = c.String(),
                        CustomerName = c.String(),
                        CustomerSurnama = c.String(),
                        CustomerGender = c.Boolean(nullable: false),
                        CustomerDateOfBirth = c.DateTime(),
                        CustomerMobilePhone = c.String(),
                        CustomerOfficePhone = c.String(),
                        CustomerMail = c.String(),
                        CustomerCreateDate = c.DateTime(),
                        CustomerCounty = c.String(),
                        CustomerDistrict = c.String(),
                        CustomerHomeAddress = c.String(),
                        CustomerNote = c.String(),
                        Archive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        NoteID = c.Int(nullable: false, identity: true),
                        NoteTitle = c.String(),
                        NoteContent = c.String(),
                        NoteReminderTime = c.DateTime(),
                        NoteReminderTimeStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.NoteID);
            
            CreateTable(
                "dbo.SupportPeriods",
                c => new
                    {
                        SupportPeriodID = c.Int(nullable: false, identity: true),
                        SupportPeriodProgress = c.String(),
                        SupportPeriodProgressDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.SupportPeriodID);
            
            CreateTable(
                "dbo.Supports",
                c => new
                    {
                        SupportID = c.Int(nullable: false, identity: true),
                        SupportTitle = c.String(),
                        SupportContent = c.String(),
                        SupportOpenDate = c.DateTime(),
                        SupportCloseDate = c.DateTime(),
                        SupportStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SupportID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Supports");
            DropTable("dbo.SupportPeriods");
            DropTable("dbo.Notes");
            DropTable("dbo.Customers");
        }
    }
}
