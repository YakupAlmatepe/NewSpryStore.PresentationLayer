using NewSpryStore.DataAccessLayer.Abstract;
using NewSpryStore.DataAccessLayer.Repositories;
using NewSpryStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpryStore.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
    }
}
