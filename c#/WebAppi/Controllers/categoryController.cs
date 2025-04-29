using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class categoryController : ControllerBase
  {
    IBll_Services.IBll_category<DTO_Commom.new_model.Category> b;
    public categoryController(IBll_Services.IBll_category<DTO_Commom.new_model.Category> b1)
    {
      b = b1;
    }
    [HttpGet]
    public ActionResult<List<DTO_Commom.new_model.Category>> GetCatagoryW()
    {
      return Ok(b.SelectAll());
    }
  }
}
