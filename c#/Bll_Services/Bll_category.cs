using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
  public class Bll_category:IBll_Services.IBll_category<DTO_Commom.new_model.Category>
  {
    IDal_Repository.IDal_category<DTO_Commom.new_model.Category> c;
    public Bll_category(IDal_Repository.IDal_category<DTO_Commom.new_model.Category> c1) {
      c = c1;
    }

    public List<DTO_Commom.new_model.Category> SelectAll()
    {
      return c.SelectAllCategory();
    }
  }
}
