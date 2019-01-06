
using EBA.Core.DataAccess.EntityFramework;
using EBA.Northwind.DataAccess.Abstract;
using EBA.Northwind.Entities.Concrete;

namespace EBA.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
