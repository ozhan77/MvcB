using ClassLibrary1.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category item)
        {
            _object.Remove(item);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category item)
        {
            c.SaveChanges();
        }

        public List<Category> list()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(Category item)
        {
            c.SaveChanges();
        }
    }
}
