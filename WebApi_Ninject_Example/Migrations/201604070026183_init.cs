namespace WebApi_Ninject_Example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 25),
                        QuantityInStock = c.Int(nullable: false),
                        Cost = c.Single(nullable: false),
                        ProductDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
