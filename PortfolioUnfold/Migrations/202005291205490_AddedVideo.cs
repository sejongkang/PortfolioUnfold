namespace PortfolioUnfold.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVideo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VideoItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PortfolioItemId = c.String(maxLength: 128),
                        Path = c.String(),
                        Title = c.String(),
                        Cation = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PortfolioItems", t => t.PortfolioItemId)
                .Index(t => t.PortfolioItemId);
            
            AddColumn("dbo.ImageItems", "Title", c => c.String());
            AddColumn("dbo.ImageItems", "Cation", c => c.String());
            AddColumn("dbo.PortfolioItems", "Member", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoItems", "PortfolioItemId", "dbo.PortfolioItems");
            DropIndex("dbo.VideoItems", new[] { "PortfolioItemId" });
            DropColumn("dbo.PortfolioItems", "Member");
            DropColumn("dbo.ImageItems", "Cation");
            DropColumn("dbo.ImageItems", "Title");
            DropTable("dbo.VideoItems");
        }
    }
}
