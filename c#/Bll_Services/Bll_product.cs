using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bll_Services
{
  public class Bll_product:IBll_Services.IBll_product<DTO_Commom.new_model.Product>
  {
    IDal_Repository.IDal_product1<DTO_Commom.new_model.Product> c;
    public Bll_product(IDal_Repository.IDal_product1<DTO_Commom.new_model.Product> c1)
    {
      c=c1; 
    }


    public async Task<List<DTO_Commom.new_model.Product>> Selectallp()
    {
      var r = await c.SelectAllProduct();
      return r;
    }

    public async Task<List<DTO_Commom.new_model.Product>> Selectbycat(int? pid,int? price, int? cid)
    {
      var z= await c.ProductsByCat(pid,price, cid );
      return z; 
    }
  }
}
