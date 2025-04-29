using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal_Repository
{
  public interface IDal_category<T>
  {
    List<T> SelectAllCategory();
  }
}
