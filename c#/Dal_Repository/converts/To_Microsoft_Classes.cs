using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.converts
{
  internal class To_Microsoft_Classes
  {
    //public static Dal_Repository.Classes.Category catM(DTO_Commom.new_model.Category category)
    //{
    //  Dal_Repository.Classes.Category c1 = new Dal_Repository.Classes.Category();
    //  c1.Id = category.Id;
    //  c1.Name = category.Name;
    //  return c1;
    //}
    //IDal_Repository.IDal_user<DTO_Commom.new_model.User> d;

    //public To_Microsoft_Classes(IDal_Repository.IDal_user<DTO_Commom.new_model.User> d1)
    //{
    //  d = d1;
    //}

    public static Dal_Repository.Classes.User userM(DTO_Commom.new_model.User user)
    {
      Dal_Repository.Classes.User u = new Dal_Repository.Classes.User();
      u.Id = user.Id;
      u.Name = user.Name;
      u.Email = user.Email;
      u.Phone = user.Phone;
      u.Birthday = user.Birthday;
      return u;
    }
    public static Dal_Repository.Classes.Buy buyM(DateTime DateOfBuy, int UserId, int AmountPay, string? Remark)
    {
      Dal_Repository.Classes.Buy b = new Dal_Repository.Classes.Buy();
      b.DateOfBuy = DateOfBuy;
      b.UserId = UserId;
      b.AmountPay = AmountPay;
      b.IsPay = false;
      if (Remark != null)
      {
        b.Remark = Remark;
      }
      
      return b;
    }
    public static Dal_Repository.Classes.Buy_Details buydetailsM(DTO_Commom.new_model.Basket bd,int buid) {
      Dal_Repository.Classes.Buy_Details bd1=new Dal_Repository.Classes.Buy_Details();
      bd1.BuyId = buid;
      bd1.ProductId = bd.pid;
      bd1.Amount = bd.qty;
      return bd1;
    }


    public static List<Dal_Repository.Classes.Buy_Details> LbuydetailsM(List<DTO_Commom.new_model.Basket> lb,int buyid)
    {
      List<Dal_Repository.Classes.Buy_Details> bd=new List<Dal_Repository.Classes.Buy_Details>();
      foreach(var b in lb)
      {
        bd.Add(buydetailsM(b,buyid));
      }
      return bd;
      
    }
  }
}
