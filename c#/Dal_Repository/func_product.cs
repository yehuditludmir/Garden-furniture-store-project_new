using Dal_Repository.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal_Repository.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Dal_Repository
{
  public class func_product : IDal_Repository.IDal_product1<DTO_Commom.new_model.Product>
  {
    GardenContext gc = new GardenContext();
    public async Task<List<DTO_Commom.new_model.Product>> SelectAllProduct()
    {
      var pp = await gc.products.Include("Company").Include("Category").ToListAsync();
      return converts.To_DTO.proDl(pp);

    }

    public async Task<List<DTO_Commom.new_model.Product>> ProductsByCat(int? pid, int? price, int? cid)
    {
      var pp = await gc.products.Include("Company").Include("Category").Where(x => x.CategoryId == pid || !pid.HasValue ||pid==0).Where(t=> !price.HasValue || (t.Price<price ||t.Price==price)).Where(m => m.CompanyId == cid || !cid.HasValue || cid==0).ToListAsync();
      return converts.To_DTO.proDl( pp);
      
    }
  }
}
 //.Where(lu => !filter.InitDate.HasValue || lu.CreationDate >= filter.InitDate.Value)
