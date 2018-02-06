namespace eCom.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addStatuses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Name) VALUES ('Active')");
            Sql("INSERT INTO Status (Name) VALUES ('Inactive')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Status WHERE Name IN ('Active', 'Inactive')");
        }
    }
}
