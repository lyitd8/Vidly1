namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNumberInStockInGenre : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Genres", "NumberInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "NumberInStock", c => c.Int(nullable: false));
        }
    }
}
