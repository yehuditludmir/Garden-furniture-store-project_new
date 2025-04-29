using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
  public class Bll_user:IBll_Services.IBll_user<DTO_Commom.new_model.User>
  {
    IDal_Repository.IDal_user<DTO_Commom.new_model.User> c;
    public Bll_user(IDal_Repository.IDal_user<DTO_Commom.new_model.User> c1)
    {
      c = c1;
    }

    public async Task<int> adduserbll(DTO_Commom.new_model.User u)
    {
      return await c.addUser(u);
    }

    public async Task<bool> loginbll(string email)
    {
      return await c.Login(email);
    }
  }
}
