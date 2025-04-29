using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class productController : ControllerBase
  {
    IBll_Services.IBll_product<DTO_Commom.new_model.Product> b;
    public productController(IBll_Services.IBll_product<DTO_Commom.new_model.Product> b1)
    {
      b = b1;
    }
    [HttpGet]
    public async Task<List<DTO_Commom.new_model.Product>> GetProductW()
    {
      return await b.Selectallp();
    }
    //[HttpGet("{ID}/{price}")]
    //[HttpGet]
    //[Route("{id:int?}/Calls/{callId:int?}")]
    //public async Task<ApiResponse<object>> GetCall(int? id = null, int? callId = null)
    //{
    //  var testRetrieve = id;
    //  var testRetrieve2 = callId;

    //  throw new NotImplementedException();
    //}

    [HttpGet("filters")]
  

    public async Task<List<DTO_Commom.new_model.Product>> GetPbyCat([FromQuery]int? ID , [FromQuery]int? price , [FromQuery]int? cid)
    {
      return await b.Selectbycat(ID, price, cid);
    }


 

  }
}
