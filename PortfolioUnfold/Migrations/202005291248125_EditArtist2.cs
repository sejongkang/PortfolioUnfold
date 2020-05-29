namespace PortfolioUnfold.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditArtist2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PortfolioItems", "Artist", c => c.String());
            DropColumn("dbo.PortfolioItems", "Aritist");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PortfolioItems", "Aritist", c => c.String());
            DropColumn("dbo.PortfolioItems", "Artist");
        }
    }
}
