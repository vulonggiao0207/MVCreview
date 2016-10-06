namespace MVCreview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Menu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dishes", "CategoryName", "dbo.Categories");
            DropIndex("dbo.Dishes", new[] { "CategoryName" });
            AddColumn("dbo.Dishes", "DishName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Dishes", "CategoryName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Dishes", "ImageLink", c => c.String(nullable: false));
            CreateIndex("dbo.Dishes", "CategoryName");
            AddForeignKey("dbo.Dishes", "CategoryName", "dbo.Categories", "CategoryName", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "CategoryName", "dbo.Categories");
            DropIndex("dbo.Dishes", new[] { "CategoryName" });
            AlterColumn("dbo.Dishes", "ImageLink", c => c.String());
            AlterColumn("dbo.Dishes", "CategoryName", c => c.String(maxLength: 128));
            DropColumn("dbo.Dishes", "DishName");
            CreateIndex("dbo.Dishes", "CategoryName");
            AddForeignKey("dbo.Dishes", "CategoryName", "dbo.Categories", "CategoryName");
        }
    }
}
