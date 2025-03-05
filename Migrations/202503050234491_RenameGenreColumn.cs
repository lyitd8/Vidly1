namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameGenreColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Genres", "Genre", "Name");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Genres", "Name", "Genre");
        }
    }
}
