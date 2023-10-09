using ClassLibrary1.Concrete;
using DataAccessLayer.Concreate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    internal class EFContactDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
