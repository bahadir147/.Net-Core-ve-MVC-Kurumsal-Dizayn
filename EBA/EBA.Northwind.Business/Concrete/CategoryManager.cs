using EBA.Northwind.Business.Abstract;
using EBA.Northwind.DataAccess.Abstract;
using EBA.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBA.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
