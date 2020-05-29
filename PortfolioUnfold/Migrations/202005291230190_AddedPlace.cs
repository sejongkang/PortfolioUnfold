namespace PortfolioUnfold.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PortfolioItems", "Place", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PortfolioItems", "Place");
        }
    }
}
