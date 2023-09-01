using BusinessLayer.Abstract;
using ClassLibrary1.Concrete;
using DataAccessLayer;
using DataAccessLayer.Concreate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //GenericRepository<Category> repo = new GenericRepository<Category>();

        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categorydal.list();
        }

    }
}
