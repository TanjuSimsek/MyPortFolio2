namespace MyPortfolio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Posts");
            AlterColumn("dbo.Categories", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Posts", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Categories", "Id");
            AddPrimaryKey("dbo.Posts", "Id");
            AddForeignKey("dbo.Posts", "CategoryId", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            DropPrimaryKey("dbo.Posts");
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Posts", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Categories", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Posts", "Id");
            AddPrimaryKey("dbo.Categories", "Id");
            AddForeignKey("dbo.Posts", "CategoryId", "dbo.Categories", "Id");
        }
    }
}
