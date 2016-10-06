namespace MVCreview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Details_Password : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerUserName", c => c.String(maxLength: 12));
            AlterColumn("dbo.Customers", "CustomerPassword", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerPassword", c => c.String());
            AlterColumn("dbo.Customers", "CustomerUserName", c => c.String());
        }
    }
}
