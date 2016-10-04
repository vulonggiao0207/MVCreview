namespace MVCreview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerEmail", c => c.String());
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Customers", "CustomerAddress", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "CustomerPhone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerPhone", c => c.String());
            AlterColumn("dbo.Customers", "CustomerAddress", c => c.String());
            AlterColumn("dbo.Customers", "CustomerName", c => c.String());
            DropColumn("dbo.Customers", "CustomerEmail");
        }
    }
}
