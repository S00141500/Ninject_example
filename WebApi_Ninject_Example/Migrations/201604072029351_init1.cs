namespace WebApi_Ninject_Example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 120));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 25));
        }
    }
}
