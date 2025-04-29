using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class userController : ControllerBase
  {
    IBll_Services.IBll_user<DTO_Commom.new_model.User> b;
    public userController(IBll_Services.IBll_user<DTO_Commom.new_model.User> b1)
    {
      b = b1;
    }
    [HttpPost]
    public async Task<int> addusercont(DTO_Commom.new_model.User u)
    {
      return await b.adduserbll(u);
    }
    [HttpGet("/byemail")]
    public  async Task<bool> loginweb(string email)
    {
      return await b.loginbll(email);
    }
  }
}
