namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreNameToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreName", c => c.String());

            Sql(@"
            UPDATE m
            SET 
                m.GenreName = g.Name
            FROM dbo.Movies m
            INNER JOIN dbo.Genres g ON m.GenreId = g.Id;
            ");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "GenreName");
        }
    }
}
