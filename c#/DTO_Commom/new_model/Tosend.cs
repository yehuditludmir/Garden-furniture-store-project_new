using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Commom.new_model
{
  //מחלקה  - שמכילה את כל הרפרטים הנזקקים להוספת קניה
  public class Tosend
  {
    //מכיל רשימה של מחלקה של סל
    //שזה האוביקט שהתקבל מצד הלקוח
    public List<Basket> listsal { get; set; }
    public string useremail { get; set; }
    public int totalpricetosend { get; set; }
  }
}
