namespace PortfolioUnfold.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditArtist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PortfolioItems", "Aritist", c => c.String());
            DropColumn("dbo.PortfolioItems", "Member");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PortfolioItems", "Member", c => c.String());
            DropColumn("dbo.PortfolioItems", "Aritist");
        }
    }
}
