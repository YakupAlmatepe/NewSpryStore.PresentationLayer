using NewSpryStore.EntityLayer.Concrete;
using newSpryStore.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpryStore.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
    }
}
