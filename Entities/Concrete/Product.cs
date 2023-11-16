using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity   //IEntity interfaceini burada ekledik.
    {
        public int ProductId { get; set; }      //ProductId tutmak için gerekli prop
        public int CategoryId { get; set; }     //CategoryId tutmak için gerekli prop
        public string ProductName { get; set; } //ProductName tutmak için gerekli prop
        public short UnitsInStock { get; set; } //UnitsInStock tutmak için gerekli prop
        public decimal UnitPrice { get; set; }  //UnitPrice tutmak için gerekli prop
    }
}
