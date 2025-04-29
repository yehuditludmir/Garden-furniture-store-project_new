using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class buy_detailsController : ControllerBase
  {
    IBll_Services.IBll_buydetails<DTO_Commom.new_model.Buy_Details> b;

    public buy_detailsController(IBll_Services.IBll_buydetails<DTO_Commom.new_model.Buy_Details> b1)
    {
      b1 = b;
    }

  }
}
