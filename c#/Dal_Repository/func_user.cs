using Dal_Repository.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
  public class func_user : IDal_Repository.IDal_user<DTO_Commom.new_model.User>
  {
    public async Task<int> addUser(DTO_Commom.new_model.User u)
    {
      GardenContext gd = new GardenContext();
      gd.users.Add(Dal_Repository.converts.To_Microsoft_Classes.userM(u));
      int z = await gd.SaveChangesAsync();
      return z;
    }
    public async Task<bool> Login(string email)
    {
      GardenContext gd = new GardenContext();
      var u = await gd.users.FirstOrDefaultAsync(x => x.Email == email);
      if (u != null)
      {
        return true;
      }
      return false;

    }
    //שליפה כל הקונה עפ אימייל
    public async Task<DTO_Commom.new_model.User> getuserbtid(string email)
    {
      
      GardenContext gd = new GardenContext();
      //שליפה מטבלת הקונים עפ האימייל
      var sz = await gd.users.FirstOrDefaultAsync(x => x.Email == email);
      //שימוש בהמרה לdto ממחלקת מיקרוסופט
      return converts.To_DTO.UserDl(sz);
      
    }
  }

}
