namespace eCom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingSupplier : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false, maxLength: 50),
                        zipcode = c.String(nullable: false, maxLength: 12),
                        City = c.String(nullable: false, maxLength: 36),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
        }
    }
}
