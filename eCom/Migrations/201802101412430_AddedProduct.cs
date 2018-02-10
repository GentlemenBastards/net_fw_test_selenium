namespace eCom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Description = c.String(nullable: false, maxLength: 500),
                        GenreId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "GenreId", "dbo.Genres");
            DropIndex("dbo.Products", new[] { "SupplierId" });
            DropIndex("dbo.Products", new[] { "GenreId" });
            DropTable("dbo.Products");
        }
    }
}
