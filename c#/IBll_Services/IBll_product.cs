using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
  public interface IBll_product<T>
  {

    Task<List<T>> Selectallp();
    Task<List<T>> Selectbycat(int? pid,int? price, int? cid);
  }
}
