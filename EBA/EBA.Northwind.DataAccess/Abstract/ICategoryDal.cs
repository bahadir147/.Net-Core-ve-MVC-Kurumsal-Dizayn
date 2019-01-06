using EBA.Core.DataAccess;
using EBA.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBA.Northwind.DataAccess.Abstract
{

    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom operation
    }
}
