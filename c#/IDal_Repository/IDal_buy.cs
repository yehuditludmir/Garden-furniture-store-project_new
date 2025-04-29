using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal_Repository
{
  public interface IDal_buy<T>
  {
    //הוספת קניה
    Task<T> addbuy(DateTime DateOfBuy, int UserId, int AmountPay, string username,string? Remark);
    //אישור תשלום
    Task<int> confirmDal(int id);
  }
}
