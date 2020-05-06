namespace CONTROL_INVENTARIO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirtsMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductCode = c.Int(nullable: false),
                        ProductName = c.String(),
                        Description = c.String(),
                        Quantity = c.String(),
                        Price = c.Int(nullable: false),
                        SupplierID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID, cascadeDelete: true)
                .Index(t => t.SupplierID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierCode = c.Int(nullable: false),
                        SupplierName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SupplierID", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "SupplierID" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
        }
    }
}
