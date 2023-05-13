namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerMAPUPDATE : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "TCNO", c => c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false));
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "CustomerSurnama", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "CustomerDateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "CustomerMobilePhone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Customers", "CustomerOfficePhone", c => c.String(maxLength: 15));
            AlterColumn("dbo.Customers", "CustomerMail", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Customers", "CustomerCreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "CustomerHomeAddress", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Customers", "CustomerNote", c => c.String(maxLength: 250));
            CreateIndex("dbo.Customers", "TCNO", unique: true);
            CreateIndex("dbo.Customers", "CustomerMobilePhone", unique: true);
            CreateIndex("dbo.Customers", "CustomerMail", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "CustomerMail" });
            DropIndex("dbo.Customers", new[] { "CustomerMobilePhone" });
            DropIndex("dbo.Customers", new[] { "TCNO" });
            AlterColumn("dbo.Customers", "CustomerNote", c => c.String());
            AlterColumn("dbo.Customers", "CustomerHomeAddress", c => c.String());
            AlterColumn("dbo.Customers", "CustomerCreateDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "CustomerMail", c => c.String());
            AlterColumn("dbo.Customers", "CustomerOfficePhone", c => c.String());
            AlterColumn("dbo.Customers", "CustomerMobilePhone", c => c.String());
            AlterColumn("dbo.Customers", "CustomerDateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Customers", "CustomerSurnama", c => c.String());
            AlterColumn("dbo.Customers", "CustomerName", c => c.String());
            AlterColumn("dbo.Customers", "TCNO", c => c.String());
        }
    }
}
