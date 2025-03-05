namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomer : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Genres",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Genre = c.String(),
            //            ReleaseDate = c.DateTime(),
            //            DateAdded = c.DateTime(),
            //            NumberInStock = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            //DropColumn("dbo.Movies", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropColumn("dbo.Movies", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
