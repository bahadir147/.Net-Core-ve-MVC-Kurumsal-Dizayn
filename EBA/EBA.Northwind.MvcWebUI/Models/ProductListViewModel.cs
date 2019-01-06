using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBA.Northwind.Entities.Concrete;

namespace EBA.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
    }
}
