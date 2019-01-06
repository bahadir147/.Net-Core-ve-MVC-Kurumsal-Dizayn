using EBA.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace EBA.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
