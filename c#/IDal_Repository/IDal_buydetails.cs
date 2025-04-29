using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal_Repository
{
  public interface IDal_buydetails<T>
  {
    Task<int> addbuydetails(List<DTO_Commom.new_model.Basket> lb, int buyid);
  }
}
