namespace PortfolioUnfold.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImageItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PortfolioItemId = c.String(maxLength: 128),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PortfolioItems", t => t.PortfolioItemId)
                .Index(t => t.PortfolioItemId);
            
            CreateTable(
                "dbo.PortfolioItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Date = c.String(),
                        Role = c.String(),
                        Client = c.String(),
                        Visit = c.String(),
                        CategoryId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TextItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PortfolioItemId = c.String(maxLength: 128),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PortfolioItems", t => t.PortfolioItemId)
                .Index(t => t.PortfolioItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TextItems", "PortfolioItemId", "dbo.PortfolioItems");
            DropForeignKey("dbo.ImageItems", "PortfolioItemId", "dbo.PortfolioItems");
            DropIndex("dbo.TextItems", new[] { "PortfolioItemId" });
            DropIndex("dbo.ImageItems", new[] { "PortfolioItemId" });
            DropTable("dbo.TextItems");
            DropTable("dbo.PortfolioItems");
            DropTable("dbo.ImageItems");
            DropTable("dbo.Categories");
        }
    }
}
