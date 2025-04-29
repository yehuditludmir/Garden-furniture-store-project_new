using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Commom;

namespace Dal_Repository.converts
{
  internal class To_DTO
  {
    
    public static DTO_Commom.new_model.Category catD(Dal_Repository.Classes.Category category)
    {
      DTO_Commom.new_model.Category c1 = new DTO_Commom.new_model.Category ();
      c1.Id = category.Id;
      c1.Name = category.Name;
      return c1;

    }

    public static List<DTO_Commom.new_model.Category> catDl(List<Dal_Repository.Classes.Category> lcategory)
    {
      List<DTO_Commom.new_model.Category> lc = new List<DTO_Commom.new_model.Category>();
      foreach (var cat in lcategory)
        lc.Add(catD(cat));
      return lc;

    }

    public static DTO_Commom.new_model.Company compD(Dal_Repository.Classes.Company company )
    {
      DTO_Commom.new_model.Company com = new DTO_Commom.new_model.Company();
      com.Id = company.Id;
      com.Name = company.Name;
      return com;

    }

    public static List<DTO_Commom.new_model.Company> compDl(List<Dal_Repository.Classes.Company> lcompany)
    {
      List<DTO_Commom.new_model.Company> lco = new List<DTO_Commom.new_model.Company>();
      foreach (var com in lcompany)
        lco.Add(compD(com));
      return lco;

    }

    public static DTO_Commom.new_model.Product proD(Dal_Repository.Classes.Product product) {
      DTO_Commom.new_model.Product pr=new DTO_Commom.new_model.Product();
      pr.Id = product.Id;
      pr.Name = product.Name;
      pr.CategoryId = product.CategoryId;
      pr.CompanyId = product.CompanyId;
      pr.Description = product.Description;
      pr.Price = product.Price;
      pr.Amount = product.Amount;
      pr.CompanyName = product.Company.Name;
      pr.CategoryName = product.Category.Name;
      pr.Picture=product.Picture;
      return pr;
      
    }
    public static List<DTO_Commom.new_model.Product> proDl(List<Dal_Repository.Classes.Product> lproduct) {
      List<DTO_Commom.new_model.Product> lpr=new List<DTO_Commom.new_model.Product>();
      foreach(var p in lproduct)
        lpr.Add(proD(p));
      return lpr; 
    }

    public static DTO_Commom.new_model.User UserDl(Dal_Repository.Classes.User user1) {
      DTO_Commom.new_model.User u = new DTO_Commom.new_model.User();
      u.Id = user1.Id;
      u.Name = user1.Name;
      u.Email = user1.Email;
      u.Phone = user1.Phone;
      u.Birthday= user1.Birthday;
      return u;
    }

    public static DTO_Commom.new_model.Buy buyD(Dal_Repository.Classes.Buy b,string username)
    {
      DTO_Commom.new_model.Buy b1=new DTO_Commom.new_model.Buy();
      b1.Id = b.Id;
      b1.UserId= b.UserId;
      b1.DateOfBuy= b.DateOfBuy;
      if (b.Remark != null) {
        b1.Remark = b.Remark;
      }
      b1.AmountPay= b.AmountPay;
      b1.UserName = username;
      return b1;
    }




  }
}
