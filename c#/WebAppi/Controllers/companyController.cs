using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class companyController : ControllerBase
  {
    IBll_Services.IBll_company<DTO_Commom.new_model.Company> b;
    public companyController(IBll_Services.IBll_company<DTO_Commom.new_model.Company> b1)
    {
      b = b1;
    }
    [HttpGet]
    public async Task<List<DTO_Commom.new_model.Company>> GetCompanyW()
    {
      return await b.Selectallcomp();
    }
  }
}
