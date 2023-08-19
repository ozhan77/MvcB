using ClassLibrary1.Concrete;
using DataAccessLayer.Concreate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAllBl()
        {
            return repo.list();
        }
        public void CategoryAddBl(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="")
            {
                
            }
            else
            {
                repo.Insert(p);

            }
        }

    }
}
