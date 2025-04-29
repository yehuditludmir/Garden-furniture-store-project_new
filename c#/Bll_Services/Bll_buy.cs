using IBll_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
  public class Bll_buy:IBll_Services.IBll_buy<DTO_Commom.new_model.Buy>
  {
    //יצירת משתנים מסוג הממשקים של המחלקות
    //dal - שאת הפונקציות שלהם נצרך כאן 
    IDal_Repository.IDal_buy<DTO_Commom.new_model.Buy> c;
    IDal_Repository.IDal_user<DTO_Commom.new_model.User> u;
    IDal_Repository.IDal_buy<DTO_Commom.new_model.Buy> b;
    IDal_Repository.IDal_buydetails<DTO_Commom.new_model.Buy_Details> d;

    //בנאי המקבל את כל הפרמטרים מסוג הממשקים הנדרשים ומכניסם למשתנים שיצרנו
    public Bll_buy(IDal_Repository.IDal_buy<DTO_Commom.new_model.Buy> c1, IDal_Repository.IDal_user<DTO_Commom.new_model.User> u1,
     IDal_Repository.IDal_buy<DTO_Commom.new_model.Buy> b1, IDal_Repository.IDal_buydetails<DTO_Commom.new_model.Buy_Details> d1)
    {
      c = c1;
      u = u1;
      b= b1;
      d = d1;
    }
    //פונקציה להוספת קניה  -
    // מקבלת אוביקט tosend -  עם כל הפרמטרים הנצרכים לקניה
    //והוא מחזיר אוביקט מסוג קניה
     // שאותו צריך להחזיר למשתמש - 
    public async Task<DTO_Commom.new_model.Buy> addbuybll(DTO_Commom.new_model.Tosend ts)
    {
      string remarkbll = "";
      //תאריך נוכחי 
      DateTime today = DateTime.Today;
      //שולח אימייל של הקונה ועל פיו הוא שולף אל כל פרטי הקונה
      DTO_Commom.new_model.User userC = await u.getuserbtid(ts.useremail);
      if (userC != null)
      {
        //בודק אם הוא בחודש היומולדת שלו
        if (today.Month == userC.Birthday.Month)
        {
          //אם יש לו יומולדת - הוא עושהל ו הנחה של 25 אחוז
          ts.totalpricetosend = ts.totalpricetosend * 75 / 100;
          //ושולח לו באת הברכה הבאה
          remarkbll += "happybirthday";
        }
      }//בודק את היום בשבוע - ובמקרה וחישי או שישי שולח לו ברכה מתאימה
      if(today.DayOfWeek== DayOfWeek.Friday || today.DayOfWeek == DayOfWeek.Thursday)
      {
        remarkbll += "ערב שבת שלום";
      }
      //שולח לפונקציה ב
      //dal - של קניה את הפרמטרים הנזקקים להוספת קניה
      DTO_Commom.new_model.Buy buy1 = await b.addbuy(today,userC.Id,ts.totalpricetosend, userC.Name, remarkbll);
      //שולח ליצירת פרטי קניה -
      //הפונציה ב dal
      //שולח את הפרמטרים הנדרשים
      int okk = await d.addbuydetails(ts.listsal, buy1.Id);
      return buy1;


    }

    //שליחה לאישור התשלום
    public async Task<int> confirmbll(int id)
    {
      return await b.confirmDal(id);  
    }

    }
}
