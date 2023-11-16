using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService   //Public bir interface oluşturuyoruz.
    {
        List<Product> GetAll();      //IEntity katmanındaki gibi GetAll listesi oluşturuyoruz.
        List<Product> GetAllCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        public List<ProductDetailDto> GetProductDetails();
    }
}
