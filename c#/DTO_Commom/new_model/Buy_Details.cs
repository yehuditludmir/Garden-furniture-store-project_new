using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Commom.new_model
{
  public class Buy_Details
  {
    public int Id { get; set; }

    public int BuyId { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; }
    public int Amount { get; set; }
  }
}
