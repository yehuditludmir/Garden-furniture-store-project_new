using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal_Repository
{
  public interface IDal_user<T>
  {
    Task<int> addUser(T u);
    Task<bool> Login(string email);
    // פנקציה שליםה עפ אימייל
    Task<T> getuserbtid(string email);
  }
}
