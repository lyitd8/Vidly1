namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDateAndDateAddedToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int());
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));

            Sql(@"
            UPDATE m
            SET 
                m.ReleaseDate = g.ReleaseDate,
                m.DateAdded = g.DateAdded,
                m.NumberInStock = g.NumberInStock
            FROM dbo.Movies m
            INNER JOIN dbo.Genres g ON m.GenreId = g.Id;
            ");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
