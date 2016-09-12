using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Ninject_Example.Models
{
    public class Product
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required, StringLength(120, MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        public int QuantityInStock { get; set; }

        [Required, DataType(DataType.Currency)]
        public float Cost { get; set; }

        [DataType(DataType.Text)]
        public string ProductDescription { get; set; }


    }

    
    public class AppContext : DbContext
    {
        public AppContext():base("AppContext")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
