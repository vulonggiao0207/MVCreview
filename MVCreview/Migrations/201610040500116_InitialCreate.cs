namespace MVCreview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        User = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Select = c.Boolean(nullable: false),
                        Insert = c.Boolean(nullable: false),
                        Update = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.User);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryName = c.String(nullable: false, maxLength: 128),
                        Del = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryName);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        DishID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 128),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        ImageLink = c.String(),
                        Availability = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Del = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DishID)
                .ForeignKey("dbo.Categories", t => t.CategoryName)
                .Index(t => t.CategoryName);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        DishID = c.Int(nullable: false),
                        OrderID = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(nullable: false),
                        PrintStatus = c.Int(nullable: false),
                        Del = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Dishes", t => t.DishID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.DishID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        OrderDate = c.String(),
                        NumberOfGuest = c.Int(nullable: false),
                        Note = c.String(),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Del = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                        CustomerPhone = c.String(),
                        CustomerUserName = c.String(),
                        CustomerPassword = c.String(),
                        Del = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.OrderDetails", "DishID", "dbo.Dishes");
            DropForeignKey("dbo.Dishes", "CategoryName", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "DishID" });
            DropIndex("dbo.Dishes", new[] { "CategoryName" });
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Dishes");
            DropTable("dbo.Categories");
            DropTable("dbo.Admins");
        }
    }
}
