using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi_Ninject_Example.DAL;
using WebApi_Ninject_Example.Models;

namespace WebApi_Ninject_Example.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            this._repo = repo;
        }


        // GET: api/Products1
        public List<Product> GetProducts()
        {
            return _repo.GetProducts();
        }

        // GET: api/Products1/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = _repo.GetProductDetail(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }


    }
}
