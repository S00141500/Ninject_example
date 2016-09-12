using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Ninject_Example.Models;

namespace WebApi_Ninject_Example.DAL
{
    public class ProductRepo : IProductRepository
    {
        private AppContext _context;

        public ProductRepo(AppContext context)
        {
            this._context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public Product GetProductDetail(int id)
        {
            Product product = _context.Products.Find(id);

            return product;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
