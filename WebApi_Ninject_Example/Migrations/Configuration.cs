namespace WebApi_Ninject_Example.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi_Ninject_Example.Models.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebApi_Ninject_Example.Models.AppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(p => p.ID,
                new Product { ID = 1121, ProductName = "Nano Wireless Mouse", Cost = 25.00F, QuantityInStock = 10, ProductDescription = "Nano Wireless Mouse,6 Buttons,18 Month Battery Life" },
                new Product { ID = 1223, ProductName = "Wireless Mouse - Red", Cost = 10.00F, QuantityInStock = 5, ProductDescription = "Plug and forget nano receiver that stays in your laptop" },
                new Product { ID = 1332, ProductName = "1 TB USB 3.0 Portable Hard Drive", Cost = 53.50F, QuantityInStock = 20, ProductDescription = "Future your conectivity with USB 2.0 and USB 3.0" },
                new Product { ID = 1114, ProductName = "1 TB Canvio Basics USB 3.0 Portable External Hard Drive", Cost = 65.00F, QuantityInStock = 13, ProductDescription = "2.5 Solid State Drive 19 nm 2 - bit - per - cell NAND flash, 7mm slim" },
                new Product { ID = 1125, ProductName = " Wireless Keyboard", Cost = 40.00F, QuantityInStock = 7, ProductDescription = "Enhanced 2.4 GHz wireless with 10 m range" },
                new Product { ID = 1826, ProductName = "Apple Wireless Keyboard", Cost = 25.00F, QuantityInStock = 10, ProductDescription = "Built-in Bluetooth technology Low -profile" }

                );

            context.SaveChanges();
        }
    }
}
