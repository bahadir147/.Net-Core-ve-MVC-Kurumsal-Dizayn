
using EBA.Core.DataAccess.EntityFramework;
using EBA.Northwind.DataAccess.Abstract;
using EBA.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBA.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
