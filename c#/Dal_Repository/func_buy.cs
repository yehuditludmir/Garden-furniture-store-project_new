using Dal_Repository.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
  public class func_buy:IDal_Repository.IDal_buy<DTO_Commom.new_model.Buy>
  {
    //הוספת קניה - מקבל את הפרמטרים הנדרשים
    public async Task<DTO_Commom.new_model.Buy> addbuy(DateTime DateOfBuy, int UserId, int AmountPay, string username, string? Remark)
    {
      GardenContext gd = new GardenContext();
      //המרה  - ליצירת אוביקט קניה של מיקרוסופט
      var newb = Dal_Repository.converts.To_Microsoft_Classes.buyM(DateOfBuy, UserId, AmountPay, Remark);
      //מוסיף לטבלת קניות את הטבלה שנוצרה
      gd.buys.Add(newb);
      //שומר שינויים
      int good =await gd.SaveChangesAsync();
      if (good > 0)
      {
        //בקרה והצליח
        //מחזיר קניה המומרת לdto
        //var a = await gd.buys.LastOrDefaultAsync(x => x.Id ==UserId);
        return Dal_Repository.converts.To_DTO.buyD(newb, username);
      }
      return null; 



    }
    //הזנת אישור תשלום
    //מקבל את קוד המשתמש
    // מחזיר הצלחה או כשלון

    public async Task<int> confirmDal(int id) {

      GardenContext gd = new GardenContext();
//שולף את הקונה
      var goodobj = await gd.buys.FirstOrDefaultAsync(x => x.Id == id);
      if (goodobj != null)
      {
        //מעדכן לו ששילם
        goodobj.IsPay=true;
      }
      //מחזיר הצלחה או כשלון
      return await gd.SaveChangesAsync();

    }

  }
}
