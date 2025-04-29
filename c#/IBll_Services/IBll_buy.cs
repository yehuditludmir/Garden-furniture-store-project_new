using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
  public interface IBll_buy<T>
  {
    Task<T> addbuybll(DTO_Commom.new_model.Tosend ts);
    Task<int> confirmbll(int id);
  }
}
