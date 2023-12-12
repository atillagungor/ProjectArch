using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1,CategoryId=1,ProductName="Asus Laptop",UnitPrice=40000,UnitsInStock=20},
                new Product {ProductId=1,CategoryId=1,ProductName="Monster Notebook",UnitPrice=42500,UnitsInStock=13},
                new Product {ProductId=1,CategoryId=2,ProductName="IPhone 15 Pro Max 1TB",UnitPrice=95000,UnitsInStock=5},
                new Product {ProductId=1,CategoryId=2,ProductName="Samsung Galaxy S24 Ultra",UnitPrice=92000,UnitsInStock=8},
                new Product {ProductId=1,CategoryId=3,ProductName="Xiaomi Airfryer",UnitPrice=25000,UnitsInStock=15}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productsToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productsToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {  
            Product productsToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productsToUpdate.CategoryId = product.CategoryId;
            productsToUpdate.ProductName = product.ProductName;
            productsToUpdate.UnitPrice = product.UnitPrice;
            productsToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
