using Dal_Repository.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
  public class func_company:IDal_Repository.IDal_company<DTO_Commom.new_model.Company>
  {
    GardenContext gc = new GardenContext();
    public async Task<List<DTO_Commom.new_model.Company>> SelectASllCompany()
    {
      var comm = await gc.companies.ToListAsync();
      return converts.To_DTO.compDl(comm);
    }

  }
}
