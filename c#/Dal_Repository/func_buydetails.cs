using Dal_Repository.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
  public class func_buydetails:IDal_Repository.IDal_buydetails<DTO_Commom.new_model.Buy_Details>
  {
    //הוספת פרטי קניה
    //מחזיר הצלחה או כשלון
    public async Task<int> addbuydetails(List<DTO_Commom.new_model.Basket> lb,int buyid)
    {
      GardenContext gc = new GardenContext();
      //ממיר ומקבל  מערך אוביקט מיקרוסופט של פרטי קניה
      var a=Dal_Repository.converts.To_Microsoft_Classes.LbuydetailsM(lb, buyid);
      //עבור כל מוצר שהוזמן
      foreach(var b in a) {
        //מעדכנים את טבלת המוצרים את הכחות שנותרה
        var cp = await gc.products.FirstOrDefaultAsync(z => z.Id == b.ProductId);
        if (cp != null)
        {
          cp.Amount = cp.Amount - b.Amount;
        }
       gc.buys_details.Add(b);
       //gc.Add(b);
      }
      return await gc.SaveChangesAsync();

    }
  }
}
