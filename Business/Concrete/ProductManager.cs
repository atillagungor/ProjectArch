using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;    //Veritabanından veriyi çekmek için bir IProductDal değişkeni oluşturuyoruz.

        public ProductManager(IProductDal productDal)   //CTOR kodu ile concrete metot oluşturuyoruz.
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();   //Oluşturduğumuz IProductDal değişkenini return komutu ile ekliyoruz.
        }

        public List<Product> GetAllCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
