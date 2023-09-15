using ClassLibrary1.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
    }
}
