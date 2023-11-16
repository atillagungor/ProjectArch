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
    public class InMemoryProductDal : IProductDal       //Interfacei bu classa ekliyoruz. (InMemory simüle olarak kendi verilerimizi hazırladığımız class)
    {
        List<Product> _products;       //Global bir alanda olduğu için _ koyarak Product içeren liste oluşturuyoruz.
        public InMemoryProductDal()    //CTOR kodu ile construct metot oluşturuyoruz.
        {
            _products = new List<Product>    //Globale tanımladığımız değişken ile yeni bir liste oluşturuyoruz.
            {
                new Product {ProductId=1,CategoryId=1,ProductName="Asus Laptop",UnitPrice=40000,UnitsInStock=20},       //Bu kısımda simülasyon olarak productları ekliyoruz
                new Product {ProductId=1,CategoryId=1,ProductName="Monster Notebook",UnitPrice=42500,UnitsInStock=13},
                new Product {ProductId=1,CategoryId=2,ProductName="IPhone 15 Pro Max 1TB",UnitPrice=95000,UnitsInStock=5},
                new Product {ProductId=1,CategoryId=2,ProductName="Samsung Galaxy S24 Ultra",UnitPrice=92000,UnitsInStock=8},
                new Product {ProductId=1,CategoryId=3,ProductName="Xiaomi Airfryer",UnitPrice=25000,UnitsInStock=15}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);        //IProductDal'ı implemente ettikten sonra Add metotunun içine, Listlerdeki veri ekleme kodunu giriyoruz.
                                           //Parantez içinde de nereye atanacağını söylüyoruz. 
        }

        public void Delete(Product product)
        {
            Product productsToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);   //LINQ sorgusu ile foreach tarzı bir döngü açarak p değeri
                                                                                                           //verdiğimiz Id ile bulup silme işlemini yapıyoruz.
            _products.Remove(productsToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;        //Void bir metot olmadığı için ve direkt listeye _products ismini verdiğimiz için return komutu ile tüm listeyi çağırıyoruz.
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();    //Tekrardan LINQ sorgusu ile categoryid ye göre tarıyor ve listeye çeviriyor.
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {  
            Product productsToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);   //LINQ ile update sorgusu çağırmak için deletedeki kodun benzerini
                                                                                                            //yazıyoruz.
            productsToUpdate.CategoryId = product.CategoryId;
            productsToUpdate.ProductName = product.ProductName;         //ID sini bulduğumuz değerleri, veritabanındaki veriler ile güncelliyoruz.
            productsToUpdate.UnitPrice = product.UnitPrice;
            productsToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
