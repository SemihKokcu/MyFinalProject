using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //bağımlılkları constructor injector ile yapıyoruz

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
        //select * from Categories where categoryId = 3,4 ?
        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.GetAll(c=>c.CategoryId == categoryId);
        }
    }
}
