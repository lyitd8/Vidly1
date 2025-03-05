namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name, ReleaseDate, DateAdded, NumberInStock) " +
            "VALUES (1, 'Comedy', '2009-10-10', '2009-11-01', 6)");
            Sql("INSERT INTO Genres (Id, Name, ReleaseDate, DateAdded, NumberInStock) " +
            "VALUES (2, 'Action', '1988-11-11', '1988-12-01', 5)");
            Sql("INSERT INTO Genres (Id, Name, ReleaseDate, DateAdded, NumberInStock) " +
            "VALUES (3, 'Action', '1984-05-10', '1984-06-01', 10)");
            Sql("INSERT INTO Genres (Id, Name, ReleaseDate, DateAdded, NumberInStock) " +
            "VALUES (4, 'Family', '1995-11-22', '1995-12-01', 4)");
            Sql("INSERT INTO Genres (Id, Name, ReleaseDate, DateAdded, NumberInStock) " +
            "VALUES (5, 'Romance', '1997-12-19', '1998-01-01', 8)");
        }
        
        public override void Down()
        {
        }
    }
}
