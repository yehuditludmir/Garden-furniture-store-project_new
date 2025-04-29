using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
  public class Bll_buydetails:IBll_Services.IBll_buydetails<DTO_Commom.new_model.Buy_Details>
  {
    IDal_Repository.IDal_buydetails<DTO_Commom.new_model.Buy_Details> c;
    public Bll_buydetails(IDal_Repository.IDal_buydetails<DTO_Commom.new_model.Buy_Details> c1)
    {
      c = c1;
    }
  }
}
