namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNameNotNull : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Default' WHERE Name IS NULL"); // Provide a default value
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: true));
        }
    }
}
