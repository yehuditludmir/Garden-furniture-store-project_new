using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
  public class Bll_company:IBll_Services.IBll_company<DTO_Commom.new_model.Company>
  {
    IDal_Repository.IDal_company<DTO_Commom.new_model.Company> c;
    public Bll_company(IDal_Repository.IDal_company<DTO_Commom.new_model.Company> c1)
    {
      c = c1;
    }
    public async Task<List<DTO_Commom.new_model.Company>> Selectallcomp()
    {
      var x = await c.SelectASllCompany();
      return x;
    }
  }
}
