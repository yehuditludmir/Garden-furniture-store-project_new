using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class buyController : ControllerBase
  {
    IBll_Services.IBll_buy<DTO_Commom.new_model.Buy> b;
    public buyController(IBll_Services.IBll_buy<DTO_Commom.new_model.Buy> b1)
    {
      b=b1; 
    }
    [HttpPost]
    //פונקציה המקבלת אוביקט tosend
    //המכיל את כל הפרמטרים הנצרכים לעדכון הקניה ופרטי הקניה
    //כל פונקציות של הקנייה
    //לאורך כל הכבות הם - async
    // - אנו מזמנות בהם את הפונקציה בשכבה הבססיסים יותר
    //ובdal - כי הוא ניגש למסד
    public async Task<DTO_Commom.new_model.Buy> addbuy(DTO_Commom.new_model.Tosend tsend)
    {
      
      return await b.addbuybll(tsend);

    }
    [HttpGet("/id")]
    public async Task<int> confirm(int id)
    {
      return await b.confirmbll(id);
    } 
  }
}
