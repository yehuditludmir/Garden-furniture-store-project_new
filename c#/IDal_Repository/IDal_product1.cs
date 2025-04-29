using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal_Repository
{
  public interface IDal_product1<T>
  {

    Task<List<T>> SelectAllProduct();
    Task<List<T>> ProductsByCat(int? pid, int? price, int? cid);

  }
}
