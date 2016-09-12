using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Ninject_Example.Models;

namespace WebApi_Ninject_Example.DAL
{
    public interface IProductRepository : IDisposable
    {
        List<Product> GetProducts();

        Product GetProductDetail(int id);
    }
}
