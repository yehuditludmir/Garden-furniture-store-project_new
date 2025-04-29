using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
  public interface IBll_user<T>
  {
    Task<int> adduserbll(T u);
    Task<bool> loginbll(string email);
  }
}
