namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdateForCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1990-01-01' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = '1995-04-01' WHERE Id = 2");
            Sql("UPDATE Customers SET Birthdate = '2000-12-10' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
