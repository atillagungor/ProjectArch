using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category: IEntity  //IEntity interfaceini burada ekledik.
    {
        public int CategoryId { get; set; }        //Category Id tutmak için gerekli prop
        public string CategoryName { get; set; }   //Category Name tutmak için gerekli prop
    }
}
